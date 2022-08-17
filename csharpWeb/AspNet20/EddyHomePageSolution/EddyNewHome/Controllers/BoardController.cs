using EddyNewHome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EddyNewHome.Controllers
{
    public class BoardController : Controller
    {
        EddyNewHomeEntities db = new EddyNewHomeEntities();

        // GET: Board
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            BoardArticles article = new BoardArticles();
            return View(article);
        }
    }
}