using System;

namespace ProductCatalogue 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRODUCT DATA LIBRARY");
            Menu menu = new Menu();
            menu.selectOptionFromMenu();
        }
    }
}


// Unsure how:
// how to use the calculateTax method on the price inputed by the user
// calculating the total of all items in the list