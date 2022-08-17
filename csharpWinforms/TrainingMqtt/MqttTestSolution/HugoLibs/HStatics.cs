using Bogus;
using Newtonsoft.Json;

namespace HugoLibs
{
    public class HStatics
    {
        public static Faker<SensorInfo> GetSensorFakeRule()
        {
            var Rooms = new[] { "DINNING", "LIVING", "BATH", "BED" }; // 부엌, 거실, 욕실, 침실

            Faker<SensorInfo> result = new Faker<SensorInfo>()
                .RuleFor(r => r.DevId, f => f.PickRandom(Rooms))
                .RuleFor(r => r.CurrTime, f => f.Date.Past(0))
                .RuleFor(r => r.Temp, f => f.Random.Float(19.0f, 30.9f))
                .RuleFor(r => r.Humid, f => f.Random.Float(40.0f, 63.9f));

            return result;
        }

        public static string GetJsonData(SensorInfo value)
        {
            var result = JsonConvert.SerializeObject(value, Formatting.Indented);
            return result;
        }
    }
}
