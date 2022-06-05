using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    public class Shoe : Product
    {
        public double Price { get;set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string Colour { get; set; }
        // Unique property to Shoe:
        public int Size { get; set; }

        public Shoe(string productName, double price, string brand, string colour, int size)
        {
            ProductName = productName;
            Price = price;
            Brand = brand;
            Colour = colour;
            Size = size;
        }

        public override string ToString()
        {
            return
                $"Product Name: {ProductName}\n" +
                $"Price: ${Price}\n" +
                $"Brand: {Brand}\n" +
                $"Colour: {Colour}\n" +
                $"Size: {Size}\n\n";
        }
    }
}
