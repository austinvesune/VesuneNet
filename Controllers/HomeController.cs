using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VesuneNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Service()
        {
            ViewBag.Message = "";

            return View();
        }
        
        public ActionResult LawnMowers()
        {
            ViewBag.Message = this.GetMyPhoneNumber();

            return View();
        }

        public string GetMyPhoneNumber ()
        {
            string phoneNUmber = "9103820928";
            return phoneNUmber;
        }
    }
}