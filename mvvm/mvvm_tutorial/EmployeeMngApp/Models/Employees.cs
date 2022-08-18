namespace EmployeeMngApp.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public string DeptName { get; set; }
        public string Destination { get; set; }

        public static readonly string SELECT_QUERY = @"SELECT Id
                                                            , EmpName
                                                            , Salary
                                                            , DeptName
                                                            , Destination
                                                         FROM Employees";
        public static readonly string INSERT_QUERY = @"INSERT INTO Employees
                                                            ( EmpName
                                                            , Salary
                                                            , DeptName
                                                            , Destination)
                                                       VALUES
                                                            ( @empName
                                                            , @salary
                                                            , @deptName
                                                            , @destination)";
        public static readonly string UPDATE_QUERY = @"UPDATE Employees
                                                          SET EmpName = @empName
                                                            , Salary = @salary
                                                            , DeptName = @deptName
                                                            , Destination = @destination
                                                        WHERE Id = @id";
        public static readonly string DELETE_QUERY = @"DELETE FROM Employees 
                                                        WHERE Id = @id ";
    }
}
