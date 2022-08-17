using Caliburn.Micro;
using MigrationUIApp.Models;
using MigrationUIApp.Services;
using MvvmDialogs;
using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace MigrationUIApp.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private readonly IWindowManager windowManager;

        private readonly IDialogService nativeDialogService;

        public ShellViewModel(IWindowManager windowManager, IDialogService nativeDialogService)
        {
            this.windowManager = windowManager;
            this.nativeDialogService = nativeDialogService;

            GetEmployees();
        }

        public void GetEmployees()
        {
            using (MySqlConnection conn = new MySqlConnection(DbServices.strConnString))
            {
                conn.Open();
                string strQuery = EmployeeTbl.SelectEmployees;
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                //MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                MySqlDataReader reader = cmd.ExecuteReader();

                Employees = new BindableCollection<EmployeesModel>();
                //DataSet ds = new DataSet();
                //adapter.Fill(ds, "Employees");
                while (reader.Read())
                {
                    var temp = new EmployeesModel
                    {
                        id = (int)reader["id"],
                        empName = reader["empName"].ToString(),
                        salary = (decimal)reader["salary"],
                        deptName = reader["deptName"].ToString(),
                        destination = reader["destination"].ToString()
                    };

                    Employees.Add(temp);
                }
            }
        }

        int id;

        public int Id
        {
            get => id;
            set
            {
                id = value;
                NotifyOfPropertyChange(() => Id);
            }
        }

        string empName;
        public string EmpName
        {
            get => empName;
            set
            {
                empName = value;
                NotifyOfPropertyChange(() => EmpName);
            }
        }

        decimal salary;
        public decimal Salary
        {
            get => salary;
            set
            {
                salary = value;
                NotifyOfPropertyChange(() => Salary);
            }
        }

        string deptName;
        public string DeptName
        {
            get => deptName;
            set
            {
                deptName = value;
                NotifyOfPropertyChange(() => DeptName);
            }
        }

        string destination;
        public string Destination
        {
            get => destination;
            set
            {
                destination = value;
                NotifyOfPropertyChange(() => Destination);
            }
        }

        private EmployeesModel selectedEmployee;
        public EmployeesModel SelectedEmployee
        {
            get => selectedEmployee;
            set
            {
                selectedEmployee = value;

                if (selectedEmployee != null)
                {
                    Id = value.id;
                    EmpName = value.empName;
                    Salary = value.salary;
                    DeptName = value.deptName;
                    Destination = value.destination;

                    NotifyOfPropertyChange(() => SelectedEmployee);
                    NotifyOfPropertyChange(() => Id);
                    NotifyOfPropertyChange(() => EmpName);
                    NotifyOfPropertyChange(() => Salary);
                    NotifyOfPropertyChange(() => DeptName);
                    NotifyOfPropertyChange(() => Destination);
                }
            }
        }

        BindableCollection<EmployeesModel> employees;
        public BindableCollection<EmployeesModel> Employees
        {
            get => employees;
            set
            {
                employees = value;
                NotifyOfPropertyChange(() => Employees);
            }
        }

        public void NewEmployee()
        {
            var dialogVM = new DialogViewModel();
            var success = windowManager.ShowDialog(dialogVM);
            if (success == true)
            {
                //Todos.Add(new TodoViewModel(dialogViewModel.Name));
            }
        }

        public void SaveEmployee()
        {
            int resultRow = 0;
            // 여기 DB처리 추가...
            using (MySqlConnection conn = new MySqlConnection(DbServices.strConnString))
            {
                conn.Open();
                string strQuery = EmployeeTbl.UpdateEmployees;
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlParameter paramId = new MySqlParameter("@id", MySqlDbType.Int32);
                paramId.Value = Id;
                cmd.Parameters.Add(paramId);
                MySqlParameter paramEmpName = new MySqlParameter("@EmpName", MySqlDbType.VarChar, 45);
                paramEmpName.Value = EmpName;
                cmd.Parameters.Add(paramEmpName);
                MySqlParameter paramSalary = new MySqlParameter("@Salary", MySqlDbType.Decimal);
                paramSalary.Value = Salary;
                cmd.Parameters.Add(paramSalary);
                MySqlParameter paramDeptName = new MySqlParameter("@DeptName", MySqlDbType.VarChar, 45);
                paramDeptName.Value = DeptName;
                cmd.Parameters.Add(paramDeptName);
                MySqlParameter paramDestination = new MySqlParameter("@Destination", MySqlDbType.VarChar, 45);
                paramDestination.Value = Destination;
                cmd.Parameters.Add(paramDestination);

                resultRow = cmd.ExecuteNonQuery();
            }

            if (resultRow > 0)
            {
                var dialogVM = new DialogViewModel();
                var success = windowManager.ShowDialog(dialogVM);

                GetEmployees();
            }
        }

    }
}
