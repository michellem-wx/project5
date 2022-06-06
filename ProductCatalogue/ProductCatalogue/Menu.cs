using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    public class Menu
    {

        // Q. why do we add new lists here..
        Catalogue<Bag> bagCatalogue = new Catalogue<Bag>();
        Catalogue<Shoe> shoeCatalogue = new Catalogue<Shoe>();

        public void displayMenuOptions()
        {
            Console.WriteLine("\n----------\nPlease select an option from the menu by adding the number only:");
            Console.WriteLine("1) Create new product");
            Console.WriteLine("2) View a catalogue");
            Console.WriteLine("3) Add a product to a catalogue");
            Console.WriteLine("4) Remove a product");
            Console.WriteLine("5) Clear catalogue");
            Console.WriteLine("6) Exit");
        }

        public void selectOptionFromMenu()
        {
            bool exit = false;
            Bag newBag = null;
            Shoe newShoe = null;

            while (!exit)
            {
                displayMenuOptions();
                int userSelectedOption = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\nSelected: {userSelectedOption}\n");

                switch (userSelectedOption)
                {
                    case 1:
                        Console.WriteLine("Select ONE of the options:");
                        Console.WriteLine("1) Create new bag product");
                        Console.WriteLine("2) Create new shoe product\n");
                        int userSelectedOptionForNewItem = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"\nSelected: {userSelectedOptionForNewItem}\n");

                        if (userSelectedOptionForNewItem == 1)
                        {
                            newBag = CreateNewBagItem.CreateNewBag();
                            //newBag = Bag.CreateNewBag();
                            Console.WriteLine($"\nNew bag product has been created: {newBag.ProductName}\n\n");

                            // NEED TO SAVE THIS DATA:

                            #region Serialise
                            //// serialise method to SAVE TO MEMORY (i.e. translating the string Bag object to JSON string/format)
                            //string jsonObject = JsonSerializer.Serialize(newBag);

                            //// I'm pretty sure im missing creating the actual text file
                            //// Creating your JSON file - i think this might be creating a new one each time.. 

                            //// SET UP FILE PATH:
                            //string filePath = Path.Combine(Directory.GetCurrentDirectory(), "bagCatalogue.JSON");

                            //// CREATE THE ACTUAL FILE:
                            //// writing the jsonObject (userinput) to the file you created above ^^
                            //File.WriteAllText(filePath, jsonObject);

                            //// I want to append all text to save what products have been *created
                            //File.AppendAllText(filePath, newBag.ToString()); 
                            #endregion


                        }
                        else
                        {
                            newShoe = CreateNewShoeItem.CreateNewShoe();
                            Console.WriteLine($"\nNew shoe product has been created: {newShoe.ProductName}\n\n");
                        }
                        break;

                    case 2:
                        Console.WriteLine("View a catalogue");
                        Console.WriteLine("Select ONE of the options:");
                        Console.WriteLine("1) View BAG catalogue");
                        Console.WriteLine("2) View SHOE catalogue");
                        int userSelectedOptionForViewCatalogue = Convert.ToInt32(Console.ReadLine());

                        if (userSelectedOptionForViewCatalogue == 1)
                        {
                            if (bagCatalogue.DigitalCatalogue.Count == 0)
                            {
                                Console.WriteLine("\nBag catalogue is EMPTY\n");
                            }
                            foreach (Bag item in bagCatalogue.DigitalCatalogue)
                            {
                                Console.WriteLine($"\nProducts in BAG catalogue: {item.ProductName}");
                            }

                        }
                        else
                        {
                            if (shoeCatalogue.DigitalCatalogue.Count == 0)
                            {
                                Console.WriteLine("\nShoe catalogue is EMPTY\n");
                            }
                            foreach (Shoe item in shoeCatalogue.DigitalCatalogue)
                            {
                                Console.WriteLine($"Products in SHOE catalogue:{item.ProductName}");
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Add a product to a catalogue\n");
                        Console.WriteLine("Select ONE of the options:");
                        Console.WriteLine("1) Add a bag product to the BAG catalogue");
                        Console.WriteLine("2) Add a shoe product to the SHOE catalogue");
                        int userSelectedOptionForAddToCatalogue = Convert.ToInt32(Console.ReadLine());

                        if (userSelectedOptionForAddToCatalogue == 1)
                        {
                            
                            bagCatalogue.AddProduct(newBag);
                            Console.WriteLine($"\nBag has been added: {newBag.ProductName}\n");

                            // issues - not dynamic enough. it automatically adds the last bag created
                            // option required to have the user enter a particular product name to be added to the catalogue
                            // similar to how we would remove a bag
                        }
                        else
                        {
                            shoeCatalogue.AddProduct(newShoe);
                            Console.WriteLine($"\nShoe has been added {newShoe.ProductName}\n");
                        }
                        break;

                    #region Old code for case 4
                    //case 4:
                    //    Console.WriteLine("Remove a product from a catalogue\n");
                    //    Console.WriteLine("Select ONE of the options:");
                    //    Console.WriteLine("1) Remove a bag product to the BAG catalogue");
                    //    Console.WriteLine("2) Remove a shoe product to the SHOE catalogue");
                    //    int userSelectedOptionForRemoval = Convert.ToInt32(Console.ReadLine());

                    //    if (userSelectedOptionForRemoval == 1)
                    //    {
                    //        Console.WriteLine("\nEnter bag name to REMOVE from the catalogue\n");
                    //        string bagName = Console.ReadLine();
                    //        bagCatalogue.RemoveProduct(bagName);
                    //    }
                    //    break;
                    #endregion
                    case 4:
                        Console.WriteLine("Remove a product from a catalogue\n");
                        Console.WriteLine("Select ONE of the options:");
                        Console.WriteLine("1) Remove a bag product to the BAG catalogue");
                        Console.WriteLine("2) Remove a shoe product to the SHOE catalogue");
                        int userSelectedOptionForRemoval = Convert.ToInt32(Console.ReadLine());

                        if (userSelectedOptionForRemoval == 1)
                        {
                            Console.WriteLine("\nEnter bag name to REMOVE from the catalogue\n");
                            string bagName = Console.ReadLine();
                            bagCatalogue.RemoveProduct(bagName);


                            Console.WriteLine($"Bag has been REMOVED");
                            foreach (Bag item in bagCatalogue.DigitalCatalogue)
                            {
                                Console.WriteLine(item.ProductName);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter shoe name to REMOVE from the catalogue");
                            string shoeName = Console.ReadLine();
                            shoeCatalogue.RemoveProduct(shoeName);

                            foreach (Shoe item in shoeCatalogue.DigitalCatalogue)
                            {
                                Console.WriteLine($"Products in SHOE catalogue:{item.ProductName}");
                            }
                            Console.WriteLine("Shoe has been REMOVED");
                        }

                        break;

                    case 5: 
                        Console.WriteLine("Remove all products from a catalogue\n");
                        Console.WriteLine("Select ONE of the options:");
                        Console.WriteLine("1) CLEAR ALL products from the BAG catalogue");
                        Console.WriteLine("2) CLEAR ALL products from the SHOE catalogue");
                        int userSelectedOptionToClearAll = Convert.ToInt32(Console.ReadLine());

                        if (userSelectedOptionToClearAll == 1)
                        {
                            bagCatalogue.ClearAllProducts();
                        }
                        else
                        {
                            shoeCatalogue.ClearAllProducts();
                        }
                        break;

                    case 6:
                        exit = true;
                        break;
                }
            }
        }
    }
}
