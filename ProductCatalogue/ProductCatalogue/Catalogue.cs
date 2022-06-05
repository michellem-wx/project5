using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;



namespace ProductCatalogue
{

    // T can be Product:BAG OR Product:SHOE
    public class Catalogue<T> where T : Product
    {
        // Created a generic list to store data into 
        public List<T> DigitalCatalogue = new List<T>();
        
        //public Catalogue()
        //{

        //}

        // Add a Product to a catalogue
        public void AddProduct(T productItem)
        {
            DigitalCatalogue.Add(productItem);
        }

        // Remove a Product from a catalogue
        public void RemoveProduct(string productName)
        {
            // Assumming its not there (-1 is your invalid index number)
            int itemToRemoveIndex = -1;

            for (int i = 0; i < DigitalCatalogue.Count; i++)
            {
                if (DigitalCatalogue[i].ProductName == productName)
                {
                    itemToRemoveIndex = i;
                    break;
                }
            }
            if (itemToRemoveIndex == -1)
            {

            }
            else
            {
                DigitalCatalogue.RemoveAt(itemToRemoveIndex);

            }

        }


        // Saving a Product to the catalogue





        // Clear all the products from catalogue
        public void ClearAllProducts()
        {
            DigitalCatalogue.Clear();
        }

    }
}
