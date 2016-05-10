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

        public ViewResult CreateProduct()
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

        public ViewResult CreateCollection()
        {
            string[] stringArray = { "apple", "orange", "plum" };

            List<int> intList = new List<int>
            {
                10,20,30,40
            };

            Dictionary<string, int> myDict = new Dictionary<string, int>
            {
                {"apple", 10 }, {"orange", 20 }, {"plum", 30 }
            };

            return View("Result", (object)stringArray[1]);
        }

        public ViewResult UseExtension()
        {
            ShoppingCart cart = new ShoppingCart
            {
                Products = new List<Product>
                {
                    new Product {Name = "Kayak", Price = 275M },
                    new Product {Name = "Life Jacket", Price = 48.95M },
                    new Product {Name = "Soccer Ball", Price = 19.50M },
                    new Product {Name = "Corner Flag", Price = 34.95M }
                }
            };

                                //Call TotalPrices as if it were part of ShoppingCart
            decimal cartTotal = cart.TotalPrices();

            return View("Result", (object)String.Format("Total: {0:c}", cartTotal));
        }

        public ViewResult UseExtensionEnumerable()
        {
            IEnumerable<Product> products = new ShoppingCart
            {
                Products = new List<Product>
                {
                    new Product {Name = "Kayak", Price = 275M },
                    new Product {Name = "Life Jacket", Price = 48.95M },
                    new Product {Name = "Soccer Ball", Price = 19.50M },
                    new Product {Name = "Corner Flag", Price = 34.95M }
                }
            };

            Product[] productArray =
            {
                    new Product {Name = "Kayak", Price = 275M },
                    new Product {Name = "Life Jacket", Price = 48.95M },
                    new Product {Name = "Soccer Ball", Price = 19.50M },
                    new Product {Name = "Corner Flag", Price = 34.95M }
            };

            decimal cartTotal = products.TotalPrices();
            decimal arrayTotal = products.TotalPrices();

            return View("Result", (object)String.Format("Cart Total: {0}, Array Total: {1}", cartTotal, arrayTotal));
        }

        public ViewResult UseFilterExtensionMethod()
        {
            IEnumerable<Product> products = new ShoppingCart
            {
                Products = new List<Product>
                {
                    new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
                    new Product {Name = "Lifejacket", Category = "Watersports",
                       Price = 48.95M},
                    new Product {Name = "Soccer ball", Category = "Soccer",
                       Price = 19.50M},
                    new Product {Name = "Corner flag", Category = "Soccer",
                       Price = 34.95M}
                }
            };

            decimal total = 0;
            foreach(Product prod in products.FilterByCategory("Soccer"))
            {
                total += prod.Price;
            }

            return View("Result", (object)String.Format("Total: {0}", total));
        }
    }
}