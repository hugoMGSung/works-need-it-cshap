using Caliburn.Micro;
using LiveCharts;
using MySql.Data.MySqlClient;
using OxyPlot;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using WpfMqttMonApp.Helpers;
using WpfMqttMonApp.Models;

namespace WpfMqttMonApp.ViewModels
{
    internal class HistoryViewModel : Conductor<object>
    {
        BindableCollection<DivisionModel> divisions;

        public BindableCollection<DivisionModel> Divisions
        {
            get => divisions;
            set
            {
                divisions = value;
                NotifyOfPropertyChange(() => Divisions);
            }
        }

        DivisionModel selectedDivision;
        public DivisionModel SelectedDivision
        {
            get => selectedDivision;
            set
            {
                selectedDivision = value;
                NotifyOfPropertyChange(() => SelectedDivision);
            }
        }

        string startDate;
        public string StartDate
        {
            get => startDate;
            set
            {
                startDate = DateTime.Parse(value).ToString("yyyy-MM-dd");
                endDate = DateTime.Parse(startDate).AddDays(1).ToString("yyyy-MM-dd");
                NotifyOfPropertyChange(() => StartDate);
                NotifyOfPropertyChange(() => EndDate);
            }
        }

        string endDate;
        public string EndDate
        {
            get => endDate;
            set
            {
                endDate = value;
                NotifyOfPropertyChange(() => EndDate);
            }
        }

        IList<DataPoint> tempValues;
        public IList<DataPoint> TempValues
        {
            get => tempValues;
            set
            {
                tempValues = value;
                NotifyOfPropertyChange(() => TempValues);
            }
        }

        IList<DataPoint> humidValues;
        public IList<DataPoint> HumidValues
        {
            get => humidValues;
            set
            {
                humidValues = value;
                NotifyOfPropertyChange(() => HumidValues);
            }
        }

        IList<DataPoint> pressValues;
        public IList<DataPoint> PressValues
        {
            get => pressValues;
            set
            {
                pressValues = value;
                NotifyOfPropertyChange(() => PressValues);
            }
        }

        public HistoryViewModel()
        {
            InitControls();
        }

        private void InitControls()
        {
            Divisions = new BindableCollection<DivisionModel>
            {
                new DivisionModel { KeyVal = 0, DivisionVal = "Select" },
                new DivisionModel { KeyVal = 1, DivisionVal = "DiningRoom" },
                new DivisionModel { KeyVal = 2, DivisionVal = "LivingRoom" },
                new DivisionModel { KeyVal = 3, DivisionVal = "BedRoom" },
                new DivisionModel { KeyVal = 4, DivisionVal = "BathRoom" },
                new DivisionModel { KeyVal = 5, DivisionVal = "GuestRoom" }
            };

            SelectedDivision = Divisions.Where(v => v.DivisionVal.Contains("Select")).FirstOrDefault();

            // Init DatePicker 
            // from DB
            Commons.CONNSTRING = "Server=localhost;Port=3306;" +
                                "Database=iot_sensordata;Uid=root;Pwd=mysql_p@ssw0rd";
            using (var conn = new MySqlConnection(Commons.CONNSTRING))
            {
                string strInsQuery = $"SELECT " + "" +
                                      " date_format(Curr_Time, '%Y-%m-%d') AS First_Date " +
                                      "  FROM smarthometbl " +
                                      " WHERE id = 1 ";

                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(strInsQuery, conn);
                    string result = cmd.ExecuteScalar().ToString();
                    StartDate = result;

                    EndDate = DateTime.Parse(result).AddDays(1).ToString("yyyy-MM-dd");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        /// <summary>
        /// Search 버튼 클릭이벤트
        /// </summary>
        public void SearchHistory()
        {
            GetDataAndVisualization();
        }

        private void GetDataAndVisualization()
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            TempValues = new List<DataPoint>();
            HumidValues = new List<DataPoint>();
            PressValues = new List<DataPoint>();
            List<DataPoint> ListTemps = new List<DataPoint>();
            List<DataPoint> ListHumids = new List<DataPoint>();
            List<DataPoint> ListPresses = new List<DataPoint>();

            // 데이터 검색해서 라이브차트에 뿌리기
            if (SelectedDivision.KeyVal == 0)
            {
                var windowManager = new WindowManager();
                windowManager.ShowDialog(new ErrorPopupViewModel("Report|Select correct division."));
                return;
            }

            // DB에서 데이터 가져와서 
            using (var conn = new MySqlConnection(Commons.CONNSTRING))
            {
                string strInsQuery = $"SELECT FORMAT(Temp, 2) AS Temp, " +
                                      "       FORMAT(Humid, 2) AS Humid, FORMAT(Press, 2) AS Press " +
                                      "  FROM smarthometbl " +
                                      " WHERE Dev_Id = @Dev_Id " +
                                      "   AND Curr_Time BETWEEN @StartDate AND @EndDate " +
                                      " ORDER BY id ";
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(strInsQuery, conn);
                    MySqlParameter parmDevId = new MySqlParameter("@Dev_Id", MySqlDbType.VarChar);
                    parmDevId.Value = SelectedDivision.DivisionVal;
                    cmd.Parameters.Add(parmDevId);
                    MySqlParameter parmStartDate = new MySqlParameter("@StartDate", MySqlDbType.VarChar);
                    parmStartDate.Value = StartDate;
                    cmd.Parameters.Add(parmStartDate);
                    MySqlParameter parmEndDate = new MySqlParameter("@EndDate", MySqlDbType.VarChar);
                    parmEndDate.Value = EndDate;
                    cmd.Parameters.Add(parmEndDate);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    var i = 0;
                    while (reader.Read())
                    {
                        ListTemps.Add(new DataPoint(i, Convert.ToDouble(reader["Temp"])));
                        ListHumids.Add(new DataPoint(i, Convert.ToDouble(reader["Humid"])));
                        ListPresses.Add(new DataPoint(i, Convert.ToDouble(reader["Press"])));

                        i++;
                    }

                    if (i == 0)
                    {
                        var windowManager = new WindowManager();
                        windowManager.ShowDialog(new ErrorPopupViewModel("Report|There is no data."));
                        return;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }

            // Chart 생성
            TempValues = ListTemps;
            HumidValues = ListHumids;
            PressValues = ListPresses;
        }
    }
}