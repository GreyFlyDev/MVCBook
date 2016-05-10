using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chapter4.Models
{
    public static class MyExtensionMethods
    {
                                            //Get ShoppingCart (Variable cartParam)
                                       //this declares it is an Extension method
                                       //ShoppingCart is the class it can be applied to 
                                       //Refer to this instance using the cartParam Parameter
        public static decimal TotalPrices(this IEnumerable<Product> productEnum)
        {
            decimal total = 0;
            //get Products from ShoppiingCart.cs 
            //through cartParam Variable
            foreach (Product prod in productEnum) 
            {
                total += prod.Price;
            }

            return total;
        }

        public static IEnumerable<Product> FilterByCategory(
            this IEnumerable<Product> productEnum, string categoryParam)
        {
            foreach(Product prod in productEnum)
            {
                if (prod.Category == categoryParam)
                {
                    yield return prod;
                }
            }
        }
    }
}