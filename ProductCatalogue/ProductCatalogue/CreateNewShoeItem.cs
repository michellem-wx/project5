using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    public class CreateNewShoeItem
    {

        // Using type Shoe, in the CreateNewShoeItemClass, applying CreateNewShoe method
        public static Shoe CreateNewShoe()
        {
            Console.WriteLine("== NEW SHOE ITEM ==");

            Console.WriteLine("Add in the product name:");
            string productName = Console.ReadLine();

            Console.WriteLine("Add in price:");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Add in brand name:");
            string brand = Console.ReadLine();

            Console.WriteLine("Add in colour:");
            string colour = Console.ReadLine();

            Console.WriteLine("Add in shoe size:");
            int size = Convert.ToInt32(Console.ReadLine());

            return new Shoe(productName, price, brand, colour, size);
        }
    }
}
