using Bogus;
using Newtonsoft.Json;
using System;

namespace BogusFakeTempHumidApp
{
    class Program
    {
        static void Main()
        {
            var Rooms = new[] { "DiningRoom", "LivingRoom", "BathRoom", "BedRoom" };

            var sensorFaker = new Faker<SensorInfo>()
                .RuleFor(o => o.Dev_Id, f => f.PickRandom(Rooms))
                .RuleFor(o => o.Curr_Time, f => f.Date.Past(0))
                .RuleFor(o => o.Temp, f => f.Random.Float(20.0f, 35.9f))
                .RuleFor(o => o.Humid, f => f.Random.Float(40.0f, 63.9f))
                .RuleFor(o => o.Press, f => f.Random.Float(899.0f, 1005.9f));


            var thisValue = sensorFaker.Generate();

            Console.WriteLine(JsonConvert.SerializeObject(thisValue, Formatting.Indented));
        }
    }
}
