using Caliburn.Micro;
using EmployeeMngApp.Models;
using System.Data.SqlClient;
using System.Windows;

namespace EmployeeMngApp.ViewModels
{
    public class MainViewModel : Conductor<object>
    {
        //private readonly string connstring = "Data Source=localhost;Initial Catalog=EMS;Integrated Security=True";
        private BindableCollection<Employees> employees;

        public BindableCollection<Employees> Employees
        {
            get => employees;
            set
            {
                employees = value;
                NotifyOfPropertyChange(() => Employees);
            }
        }

        private int id;
        public int Id
        {
            get => id;
            set
            {
                id = value;
                NotifyOfPropertyChange(() => Id);
                NotifyOfPropertyChange(() => CanDelEmployee);  // 삭제버튼 활성/비활성화
            }
        }

        private string empName;
        public string EmpName
        {
            get => empName;
            set
            {
                empName = value;
                NotifyOfPropertyChange(() => EmpName);
                NotifyOfPropertyChange(() => CanSaveEmployee); // 저장버튼 활성/비활성화
            }
        }

        private decimal salary;
        public decimal Salary
        {
            get => salary;
            set
            {
                salary = value;
                NotifyOfPropertyChange(() => Salary);
                NotifyOfPropertyChange(() => CanSaveEmployee); // 저장버튼 활성/비활성화
            }
        }

        private string deptName;
        public string DeptName
        {
            get => deptName;
            set
            {
                deptName = value;
                NotifyOfPropertyChange(() => DeptName);
                NotifyOfPropertyChange(() => CanSaveEmployee); // 저장버튼 활성/비활성화
            }
        }

        private string destination;
        public string Destination
        {
            get => destination;
            set
            {
                destination = value;
                NotifyOfPropertyChange(() => Destination);
            }
        }

        private Employees selectedEmployee;
        public Employees SelectedEmployee
        {
            get => selectedEmployee;
            set
            {
                selectedEmployee = value;

                if (selectedEmployee != null)
                {
                    Id = value.Id;
                    EmpName = value.EmpName;
                    Salary = value.Salary;
                    DeptName = value.DeptName;
                    Destination = value.Destination;

                    NotifyOfPropertyChange(() => SelectedEmployee);
                    /*NotifyOfPropertyChange(() => Id);          // "" != null
                    NotifyOfPropertyChange(() => EmpName);
                    NotifyOfPropertyChange(() => Salary);
                    NotifyOfPropertyChange(() => DeptName);
                    NotifyOfPropertyChange(() => Destination);*/ // 주석을 풀어도 무방
                }
            }
        }

        public MainViewModel()
        {
            DisplayName = "Employee Management App";

            // DB연결
            GetEmployees();
        }

        public void GetEmployees()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(Models.Employees.SELECT_QUERY, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                Employees = new BindableCollection<Employees>();

                while (reader.Read())
                {
                    var empTmp = new Employees
                    {
                        Id = (int)reader["Id"],
                        EmpName = reader["EmpName"].ToString(),
                        Salary = (decimal)reader["Salary"],
                        DeptName = reader["DeptName"].ToString(),
                        Destination = reader["Destination"].ToString()
                    };
                    Employees.Add(empTmp);
                }
            }
        }

        public bool CanSaveEmployee
        {
            get => !string.IsNullOrEmpty(EmpName) && Salary > 0 && !string.IsNullOrEmpty(DeptName);
        }

        public void SaveEmployee()
        {
            int resultRow = 0;  // UPDATE 기본 1, INSERT 기본 1

            // Validation check 
            /*if (string.IsNullOrEmpty(EmpName) || Salary == 0 || string.IsNullOrEmpty(DeptName))
            {
                MessageBox.Show("입력값에 빈값이 있습니다");
                return;
            }*/

            try
            {
                using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    if (Id == 0) // insert
                        cmd.CommandText = Models.Employees.INSERT_QUERY;
                    else // update 
                        cmd.CommandText = Models.Employees.UPDATE_QUERY;

                    SqlParameter empNameParam = new SqlParameter("@empName", EmpName);
                    cmd.Parameters.Add(empNameParam);
                    SqlParameter salaryParam = new SqlParameter("@salary", Salary);
                    cmd.Parameters.Add(salaryParam);
                    SqlParameter deptNameParam = new SqlParameter("@deptName", DeptName);
                    cmd.Parameters.Add(deptNameParam);
                    SqlParameter destinationParam = new SqlParameter("@destination", Destination);
                    cmd.Parameters.Add(destinationParam);

                    if (Id != 0) // Update일때만 Id 사용 (분기안하면 무조건 에러)
                    {
                        SqlParameter idParam = new SqlParameter("@id", Id);
                        cmd.Parameters.Add(idParam);
                    }                   

                    resultRow = cmd.ExecuteNonQuery();

                    if (resultRow > 0)
                    {
                        MessageBox.Show("저장되었습니다!");
                        GetEmployees();
                    }
                    else
                    {
                        MessageBox.Show("데이터 저장 실패!");
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"예외발생 : {ex.Message}");
                //return;
            }
            finally
            {
                NewEmployee();
            }
        }


        // 신규버튼 클릭 | 저장이후 입력컨트롤 비우기
        public void NewEmployee()
        {
            Id = 0;
            Salary = 0;
            EmpName = DeptName = Destination = string.Empty;
        }

        public bool CanDelEmployee
        {
            get => Id != 0;
        }

        public void DelEmployee()
        {
            // 삭제 검증
            /*if (Id == 0)
            {
                MessageBox.Show("삭제할 수 없습니다");
                return;
            }*/

            try
            {
                using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(Models.Employees.DELETE_QUERY, conn);

                    SqlParameter idParam = new SqlParameter("@id", Id);
                    cmd.Parameters.Add(idParam);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("삭제되었습니다.");
                        GetEmployees();
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"예외발생 : {ex.Message}");
            }
            finally
            {
                NewEmployee();
            }
        }
    }
}
