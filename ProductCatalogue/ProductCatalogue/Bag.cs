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


        //public static CreateNewBag()
        //{
        //    Console.WriteLine("== NEW BAG ITEM ==");
        //    Console.WriteLine("TESTTTTTTTTTTTTTTTT");

        //    Console.WriteLine("Add in the product name:");
        //    string productName = Console.ReadLine();

        //    Console.WriteLine("Add in price (before tax):");
        //    double price = Convert.ToDouble(Console.ReadLine());

        //    // Q. DO I NEED GET AND SET?!?
        //    //Console.WriteLine(Bag.CalculateTax(price));

        //    Console.WriteLine("Add in brand name:");
        //    string brand = Console.ReadLine();

        //    Console.WriteLine("Add in colour:");
        //    string colour = Console.ReadLine();

        //    Console.WriteLine("Add in category:");
        //    string category = Console.ReadLine();


        //    // WHY?!?!?!
        //    Console.WriteLine("Price after tax:");
        //    Console.WriteLine(new Bag(productName, price, brand, colour, category).CalculateTax());

        //    return new Bag(productName, price, brand, colour, category);

        //}

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
