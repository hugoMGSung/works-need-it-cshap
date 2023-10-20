using System;

namespace wp10_employeesApp.Models
{
    public class Employees
    {
        private int salary;

        public int Idx { get; set; }
        public string FullName { get; set; }
        public int Salary { 
            get => salary;
            set
            {
                if (value <= 0 || value > 50000000)
                {
                    throw new Exception("급여 오류");
                }
                else
                {
                    salary = value;
                }
            }
        }
        public string DeptName { get; set; }
        public string Address { get; set; }
    }
}
