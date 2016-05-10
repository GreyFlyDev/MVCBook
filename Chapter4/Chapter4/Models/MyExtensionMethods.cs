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
        public static decimal TotalPrices(this ShoppingCart cartParam)
        {
            decimal total = 0;
                                    //get Products from ShoppiingCart.cs 
                                    //through cartParam Variable
            foreach(Product prod in cartParam.Products)
            {
                total += prod.Price;
            }

            return total;
        }
    }
}