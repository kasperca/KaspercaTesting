using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkovbakkenWebsite.Models;

namespace SkovbakkenWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Shift> shifts = new List<Shift>();
            shifts.Add(new Shift(new DateTime(2017, 3, 24, 10, 0, 0), new DateTime(2017, 3, 24, 14, 0, 0), "Kitchen", 6, "hey"));

            return View(shifts);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}