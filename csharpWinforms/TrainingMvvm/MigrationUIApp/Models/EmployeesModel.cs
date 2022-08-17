namespace MigrationUIApp.Models
{
    //public class MvvmDnContext : DbContext
    //{
    //    public DbSet<EmployeesModel> Employees { get; set; }

    //    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    //{
    //    //    optionsBuilder.UseMySql(@"Server=localhost;Database=mvvm_dn;User=root;Password=mysql_p@ssw0rd");
    //    //}

    //}

    public class EmployeesModel
    {
        public int id { get; set; }
        public string empName { get; set; }
        public decimal salary { get; set; }
        public string deptName { get; set; }
        public string destination { get; set; }
    }
}
