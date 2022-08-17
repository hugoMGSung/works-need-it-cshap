using System.Collections.Generic;
using System.Threading.Tasks;
using UsingWebApiApp.Models;

namespace UsingWebApiApp.Services
{
    public interface IHolidaysApiService
    {
        Task<List<HolidayModel>> GetHolidays(string countryCode, int year);
    }
}
