using System;

namespace wp12_finedustCheck.Models
{
    public class DustSensor
    {
        /*
      "dev_id": "B4E62D460C9E",
      "name": "미세먼지19",
      "loc": "서상동 306-24 수로왕릉입구 광장 가로등주",
      "coordx": "128.87892793651744",
      "coordy": "35.23352393922928",
      "ison": true,
      "pm10_after": 35,
      "pm25_after": 15,
      "state": 0,
      "timestamp": "2023-04-27 14:09:25.689",
      "company_id": "bcdbe35acf834d64bf4e7ed5fdf1cf94",
      "company_name": "미세먼지 센서" */
        public int Id { get; set;}
        public string Dev_id { get; set; }
        public string Name { get; set; }
        public string Loc { get; set; }
        public double Coordx { get; set; }
        public double Coordy { get; set; }
        public bool Ison { get; set; }
        public int Pm10_after { get; set; }
        public int Pm25_after { get; set; }
        public int State { get; set; }
        public DateTime Timestamp { get; set; }
        public string Company_id { get; set; }
        public string Company_name { get; set; }
    }
}
