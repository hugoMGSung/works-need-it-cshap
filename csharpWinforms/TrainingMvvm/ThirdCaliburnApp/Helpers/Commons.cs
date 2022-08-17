using System;
using System.Text.RegularExpressions;

namespace ThirdCaliburnApp
{
    public class Commons
    {
        internal static readonly string CONNSTRING = 
            "Data source=localhost;Port=3306;Database=testdb;Uid=root;Password=mysql_p@ssw0rd";

        internal static bool IsNumeric(string text)
        {
            Regex regex = new Regex("[^0-9.-]+");
            return !regex.IsMatch(text);
        }
    }

    public class EmployeesTbl
    {
        public static string SELECT_EMPLOYEES = "SELECT id, " +
                                            "      EmpName, " +
                                            "      Salary, " +
                                            "      DeptName, " +
                                            "      Destination " +
                                            " FROM employeestbl ";

        internal static string INSERT_EMPLOYEE = "INSERT INTO employeestbl " +
                                                " ( " +
                                                "   EmpName, "+
                                                "   Salary, " +
                                                "   DeptName, "+
                                                "   Destination " +
                                                " ) VALUES( " +
                                                "   @EmpName, " +
                                                "   @Salary, " +
                                                "   @DeptName, " +
                                                "   @Destination " +
                                                " ) ";

        internal static string UPDATE_EMPLOYEE = "UPDATE employeestbl " +
                                                "    SET " +
                                                "        EmpName = @EmpName, " +
                                                "        Salary = @Salary, "+
                                                "        DeptName = @DeptName, " +
                                                "        Destination = @Destination " +
                                                " WHERE id = @id ";

        internal static string DELETE_EMPLOYEE = "DELETE FROM employeestbl " +
                                                "  WHERE id = @id ";
    }
}