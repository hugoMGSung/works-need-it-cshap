using System;

namespace Covid19MonitorApp.Models
{
    public class StatusDetails
    {
        /// <summary>
        /// 확진
        /// </summary>
        public ConfirmedCases Confirmed { get; set; } 
        
        /// <summary>
        /// 회복
        /// </summary>
        public RecoveredCases Recovered { get; set; }

        /// <summary>
        /// 사망
        /// </summary>
        public DeathCases Deaths { get; set; }

        public DateTime lastUpdate { get; set; }

        public class ConfirmedCases
        {
            public long value { get; set; }
        }

        public class RecoveredCases
        {
            public long value { get; set; }
        }

        public class DeathCases
        {
            public long value { get; set; }
        }
    }
}
