namespace MigrationUIApp.Services
{
    public class DbServices
    {
        public static string strConnString = "server=localhost;port=3306;database=mvvm_dn;uid=root;password=mysql_p@ssw0rd";
    }

    public static class EmployeeTbl
    {
        public static string SelectEmployees = "SELECT id " +
                                                "     , EmpName " +
                                                "     , Salary " +
                                                "     , DeptName " +
                                                "     , Destination " +
                                                "  FROM employees ";

        public static string UpdateEmployees = "UPDATE employees " +
                                                "  SET " +
                                                "      EmpName = @EmpName " +
                                                "    , Salary = @Salary " +
                                                "    , DeptName = @DeptName " +
                                                "    , Destination = @Destination " +
                                                "WHERE id = @id ";

        public static string InsertEmployees = "INSERT INTO employees " +
                                               "     ( id " +
                                                "    , EmpName " +
                                                "    , Salary " +
                                                "    , DeptName " +
                                                "    , Destination " +
                                                "    ) VALUES " +
                                                "    ( @id " +
                                                "    , @EmpName " +
                                                "    , @Salary " +
                                                "    , @DeptName " +
                                                "    , @Destination " +
                                                "    ) ";

        public static string DeleteEmployees = "DELETE FROM employees " +
                                                "     WHERE id = @id ";
    }
}
