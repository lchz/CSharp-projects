//using System;
//using System.Linq;
//using System.Collections.Generic;

namespace _6_CustomerMaintenance
{
    public class Product
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string code, string description, double price)
        {
            this.Code = code;   
            this.Description = description;
            this.Price = price;
        }

        public string GetDisplayText(string sep)
        {
            return this.Code + sep + this.Price.ToString("c") + sep + this.Description;
        }
    }
}