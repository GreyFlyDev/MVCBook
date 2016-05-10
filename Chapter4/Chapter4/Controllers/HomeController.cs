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
            //Fast Way
            Product myProduct = new Product
            {
                ProductID = 100,
                Name = "Kayak",
                Description = "Boat For One Person",
                Price = 275M,
                Category = "Watersports"
            };

            return View("Result", (object)String.Format("Category: {0}", myProduct.Category));
        }
    }
}