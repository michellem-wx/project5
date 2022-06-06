using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogue
{
    public abstract class Product
    {
        // Properties of Product
        public double Price;
        public string ProductName;
        public string Brand;
        public string Colour;


        // No need for the price parameter because it already knows its talking about the price property of the bag instance
        public virtual double CalculateTax()
        {
            return Math.Round((Price * 1.1),2 );    
        }
    }
}
