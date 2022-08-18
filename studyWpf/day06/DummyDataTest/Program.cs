using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new SampleRepository();
            var customers = repository.GetCustomers();

            Console.WriteLine(JsonConvert.SerializeObject(customers, Formatting.Indented));
            //Console.WriteLine(customers);
        }
    }
}
