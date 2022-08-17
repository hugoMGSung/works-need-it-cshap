using System.Diagnostics;

namespace BikeShop
{
    public class BaseClass
    {
        public int Money { get; set; }
        public string Car { get; set; }

        public void Spend() {
            Debug.WriteLine("Do something");
        }
    }
}
