using System;

namespace BogusMqttWinformApp
{
    public class SensorInfo
    {
        public string Dev_Id { get; set; }

        public DateTime Curr_Time { get; set; }

        public float Temp { get; set; }

        public float Humid { get; set; }

        public float Press { get; set; }
    }
}
