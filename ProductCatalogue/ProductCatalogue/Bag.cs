using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    public class Bag : Product
    {
        public double Price { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string Colour { get; set; }

        // Unique properties to Bag 
        public string Category { get; set; }

        public Bag(string productName, double price, string brand, string colour, string category)
        {
            ProductName = productName;
            Price = price;
            Brand = brand;
            Colour = colour;
            Category = category;
        }


        public override string ToString()
        {
            return
                $"Product Name: {ProductName}\n" +
                $"Price: ${Price}\n" +
                $"Brand: {Brand}\n" +
                $"Colour: {Colour}\n" +
                $"Category: {Category}\n\n";

        }


    }
}
