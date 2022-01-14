using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PakistanCricketNewsFan.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult History()
        {
            return View();
        }
        public ActionResult CurrentTeam()
        {
            return View();
        }
    }
}