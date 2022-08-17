using ConfigurationCheckApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;

namespace ConfigurationCheckApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration Configuration;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        public IActionResult Index()
        {
            var appName = Configuration["MyApplication:Name"];
            var appVersion = Configuration["MyApplication:Version"];
            var appUrl = Configuration["MyApplication:DefaultUrl"];
            var supportEmail = Configuration["MyApplication:Support:Email"];
            var supportPhone = Configuration["MyApplication:Support:Phone"];

            ViewBag.ApplicationName = appName;
            ViewBag.ApplicationVersion = appVersion;
            ViewBag.ApplicationUrl = appUrl;
            ViewBag.SupportEmail = supportEmail;
            ViewBag.SupportPhone = supportPhone;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
