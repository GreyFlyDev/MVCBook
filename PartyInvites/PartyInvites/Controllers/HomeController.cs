using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //Right Click Class To Create The View
        public ViewResult Index()
        {
            //Do something before returning View
            int hour = DateTime.Now.Hour;

            //Add information to dynamic object ViewBag
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
    }
}