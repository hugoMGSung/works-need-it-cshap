namespace Covid19MonitorApp.Models
{
    public class ChartData
    {
        public string Description { get; set; }
        public decimal Value { get; set; }
        public decimal ConfirmedCases { get; set; }
        public decimal RecorveredOrDeaths { get; set; }

        public ChartData(string description, decimal recorveredOrDeaths, decimal confirmedCases)
        {
            Description = description;
            ConfirmedCases = confirmedCases;
            RecorveredOrDeaths = recorveredOrDeaths;
            Value = CalculateFatalityOrRecoveryPercentage();
        }

        private decimal CalculateFatalityOrRecoveryPercentage()
        {
            return (RecorveredOrDeaths / ConfirmedCases) * 100;
        }
    }
}
