using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//needed in order to reference Model type "GuestResponse"
using PartyInvites.Models;

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

        //HttpGet Only handles Get Requests
        [HttpGet]
        //Create New RsvpForm (Right Click To Add View)
        public ViewResult RsvpForms()
        {
            return View();
        }

        //HttpPost Only handles Post Requests
        [HttpPost]
        public ViewResult RsvpForms(GuestResponse guestResponse)
        {
            //Render "Thanks" View 
            //& Pass it the "guestResponse" Object
            return View("Thanks",guestResponse);
        }
    }

}