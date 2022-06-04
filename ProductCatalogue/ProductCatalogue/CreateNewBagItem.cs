using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    public class CreateNewBagItem
    {
        public static Bag CreateNewBag()
        {
            Console.WriteLine("== NEW BAG ITEM ==");
            Console.WriteLine("Add in the product name:");
            string productName = Console.ReadLine();

            Console.WriteLine("Add in price (before tax):");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Add in brand name:");
            string brand = Console.ReadLine();

            Console.WriteLine("Add in colour:");
            string colour = Console.ReadLine();

            Console.WriteLine("Add in category:");
            string category = Console.ReadLine();

            return new Bag(productName, price, brand, colour, category);

        }
    }
}
