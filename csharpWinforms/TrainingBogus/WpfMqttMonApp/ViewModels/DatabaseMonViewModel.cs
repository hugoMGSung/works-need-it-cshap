using Caliburn.Micro;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using WpfMqttMonApp.Helpers;

namespace WpfMqttMonApp.ViewModels
{
    internal class DatabaseMonViewModel : Conductor<object>
    {
        string brokerUrl;
        public string BrokerUrl
        {
            get => brokerUrl;
            set
            {
                brokerUrl = value;
                NotifyOfPropertyChange(() => BrokerUrl);
            }
        }

        string topic;
        public string Topic
        {
            get => topic;
            set
            {
                topic = value;
                NotifyOfPropertyChange(() => Topic);
            }
        }

        string connString;
        public string ConnString
        {
            get => connString;
            set
            {
                connString = value;
                NotifyOfPropertyChange(() => ConnString);
            }
        }

        string dbLog;
        public string DbLog
        {
            get => dbLog;
            set
            {
                dbLog = value;
                NotifyOfPropertyChange(() => DbLog);
            }
        }

        public DatabaseMonViewModel()
        {
            BrokerUrl = Commons.BROKERHOST;
            Topic = Commons.PUB_TOPIC;
            Commons.CONNSTRING = ConnString = "Server=localhost;Port=3306;" +
                         "Database=iot_sensordata;Uid=root;Pwd=mysql_p@ssw0rd";
        }


        bool isConnected;

        public bool IsConnected
        {
            get => isConnected;
            set
            {
                isConnected = value;
                NotifyOfPropertyChange(() => IsConnected);
            }
        }

        public void Connect()
        {
            Commons.STATIC_CLIENT = new MqttClient(BrokerUrl);
            Commons.STATIC_CLIENT.MqttMsgPublishReceived += STATIC_CLIENT_MqttMsgPublishReceived;

            if (IsConnected)
            {
                try
                {
                    if (!Commons.STATIC_CLIENT.IsConnected)
                    {
                        Commons.STATIC_CLIENT.Connect("Monitor_Sub");
                        Commons.STATIC_CLIENT.Subscribe(new string[] { Commons.PUB_TOPIC }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                        UpdateText($">>> Message : Broker Connected");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            else
            {
                try
                {
                    if (Commons.STATIC_CLIENT.IsConnected)
                    {
                        Commons.STATIC_CLIENT.Disconnect();
                        UpdateText($">>> Message : Broker Disconnected");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        private void STATIC_CLIENT_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);
            UpdateText($">>> Message : {message}");
            InsertData(message);
        }

        private void InsertData(string message)
        {
            var currentDatas = JsonConvert.DeserializeObject<Dictionary<string, string>>(message);

            using (var conn = new MySqlConnection(ConnString))
            {
                string strInsQuery = $"INSERT INTO smarthometbl " +
                                        " (Dev_Id, " +
                                        "  Curr_Time, " +
                                        "  Temp, " +
                                        "  Humid, " +
                                        "  Press) " +
                                        " VALUES " +
                                        " (@Dev_Id, " +
                                        "  @Curr_Time, " +
                                        "  @Temp, " +
                                        "  @Humid, " +
                                        "  @Press) ";

                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(strInsQuery, conn);
                    MySqlParameter parmDevId = new MySqlParameter("@Dev_Id", MySqlDbType.VarChar);
                    parmDevId.Value = currentDatas["Dev_Id"];
                    cmd.Parameters.Add(parmDevId);
                    MySqlParameter parmCurrTime = new MySqlParameter("@Curr_Time", MySqlDbType.DateTime);
                    parmCurrTime.Value = currentDatas["Curr_Time"].Replace('T', ' ').Substring(0, currentDatas["Curr_Time"].IndexOf('+'));
                    cmd.Parameters.Add(parmCurrTime);
                    MySqlParameter parmTemp = new MySqlParameter("@Temp", MySqlDbType.Float);
                    parmTemp.Value = currentDatas["Temp"];
                    cmd.Parameters.Add(parmTemp);
                    MySqlParameter parmHumid = new MySqlParameter("@Humid", MySqlDbType.Float);
                    parmHumid.Value = currentDatas["Humid"];
                    cmd.Parameters.Add(parmHumid);
                    MySqlParameter parmPress = new MySqlParameter("@Press", MySqlDbType.Float);
                    parmPress.Value = currentDatas["Press"];
                    cmd.Parameters.Add(parmPress);

                    if (cmd.ExecuteNonQuery() == 1)
                        UpdateText("[DB] " + "Insert succeed");
                    else
                        UpdateText("[DB] " + "Insert failed");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }

        }

        private void UpdateText(string message)
        {
            DbLog += $"{message}\n";
        }
    }
}