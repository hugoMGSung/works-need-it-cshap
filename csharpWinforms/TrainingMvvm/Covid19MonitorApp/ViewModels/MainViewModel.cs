using Caliburn.Micro;
using Covid19MonitorApp.Helpers;
using Covid19MonitorApp.Models;
using System.Net;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace Covid19MonitorApp.ViewModels
{
    public class MainViewModel : PropertyChangedBase, IHaveDisplayName
    {
        public string DisplayName { get; set; }

        Countries affectedCountries;

        public Countries AffectedCountries
        {
            get { return affectedCountries; }
            set
            {
                affectedCountries = value;
                NotifyOfPropertyChange(() => AffectedCountries);
            }
        }

        Country selectedCountry;

        public Country SelectedCountry
        {
            get => selectedCountry;
            set
            {
                selectedCountry = value;
                GetRecoveryAndFatalityRateByCountry(SelectedCountry.name);
            }
        }

        StatusDetails covidDetails;

        public StatusDetails CovidDetails
        {
            get => covidDetails;
            set
            {
                covidDetails = value;
                NotifyOfPropertyChange(() => CovidDetails);
            }
        }

        List<ChartData> chartdetailsList;

        public List<ChartData> ChartdetailsList
        {
            get => chartdetailsList;
            set
            {
                chartdetailsList = value;
                NotifyOfPropertyChange(() => ChartdetailsList);
            }
        }

        private void GetRecoveryAndFatalityRateByCountry(string countryName)
        {
            var countriesRate = Commons.GetCall("countries/" + countryName);
            UpdateRecoveryAndFatalityRate(countriesRate);
        }

        private void UpdateRecoveryAndFatalityRate(Task<HttpResponseMessage> response)
        {
            if (response.Result.StatusCode == HttpStatusCode.OK)
            {
                CovidDetails = response.Result.Content.ReadAsAsync<StatusDetails>().Result; ChartdetailsList = new List<ChartData>()
                {
                   new ChartData("회복률", CovidDetails.Recovered.value,  CovidDetails.Confirmed.value),
                   new ChartData("사망률", CovidDetails.Deaths.value, CovidDetails.Confirmed.value)
                };
            }
        }

        public MainViewModel()
        {
            DisplayName = "코로나19 전세계 현황판";

            GetAllCountries();
        }

        private void GetAllCountries()
        {
            var allCountries = Commons.GetCall("countries");

            if (allCountries.Result.StatusCode == HttpStatusCode.OK)
            {
                AffectedCountries = allCountries.Result.Content.ReadAsAsync<Countries>().Result;
            }
        }
    }
}