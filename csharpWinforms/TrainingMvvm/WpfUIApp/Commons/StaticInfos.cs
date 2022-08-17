namespace WpfUIApp.Commons
{
    public static class StaticInfos
    {
        public static string CONNSTR =
            "Data Source=127.0.0.1;Initial Catalog=MvvmDB;Persist Security Info=True;User ID=sa;Password=p@ssw0rd!";
    }

    public static class InnerQuerys
    {
        public static string GETPEOPLE_QRY = "SELECT FirstName, LastName " +
                                                "  FROM dbo.PeopleTbl " +
                                                " ORDER BY Idx ASC ";
    }
}
