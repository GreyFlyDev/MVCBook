using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Add refernce to object
using Chapter4.Models;

namespace Chapter4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Result");
        }

        public ActionResult AutoProperty()
        {
            //create new product object
            Product myProduct = new Product();

            //Set property value 
            myProduct.Name = "Kayak";

            //get property
            string productName = myProduct.Name;

            //Generate View
            return View("Result", (Object)String.Format("Product Name: {0}", productName));

        }

        public ActionResult CreateProduct()
        {
            //Long Way
            Product myProduct = new Product();

            myProduct.ProductID = 100;
            myProduct.Name = "Kayak";
            myProduct.Description = "Boat for one person";
            myProduct.Price = 275M;
            myProduct.Category = "WaterSports";

            return View("Result", (object)String.Format("Category: {0}", myProduct.Category));
        }
    }
}