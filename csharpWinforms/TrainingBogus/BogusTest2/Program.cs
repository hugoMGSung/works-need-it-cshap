using Bogus;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogusTest2
{
    public class MyModel
    {
        public string Name { get; set; }
        public long Id { get; set; }
        public long Version { get; set; }
        public Date Created { get; set; }
    }

    public struct Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var modelFaker = new Faker<MyModel>()
               .RuleFor(o => o.Name, f => f.Name.FirstName())
               .RuleFor(o => o.Id, f => f.Random.Number(100, 200))
               .RuleFor(o => o.Version, f => f.Random.Number(300, 400))
               .RuleFor(o => o.Created, f =>
               {
                   var date = f.Date.Past();
                   return new Date { Day = date.Day, Month = date.Month, Year = date.Year };
               });

            var myModel = modelFaker.Generate();

            Console.WriteLine(JsonConvert.SerializeObject(myModel, Formatting.Indented));
        }

    }
}
