using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUnitTests
{
    public class ProducteRepository
    {
        /// <summary>
        /// Retrieve one product
        /// </summary>
        public Product Retrieve(int productId)
        {
            //Create the instance of Product
            //Pass the requested Id
            Product product = new Product(productId);

            //Code that retrieves the defined product
            //Temporary hard coded values to return
            //a populated product
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Siz";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        /// <summary>
        /// Retrieve 
        /// </summary>
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        /// <summary>
        /// Saves the current product
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //Code that saves the defined customer
            return true;
        }
    }
}

