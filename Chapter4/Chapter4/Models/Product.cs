using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chapter4.Models
{
    public class Product
    {
        private string name;
        //Automatic Properties
        //Automatically sets private property to get to?
        public int ProductID { get; set; }
        
        //If we need to change how Name is implemented 
        //we can go back to regular properties
        //Automatic Properties save typing and readability
        public string Name
        {
            get
            {
                return ProductID + Name;
            }

            set
            {
                name = value;
            }
        }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { set; get; }
    }
}