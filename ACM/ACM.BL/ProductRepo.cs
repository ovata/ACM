using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepo
    {
        /// <summary>
        /// Getting a product by Id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            Product prod = new Product(productId);

            if (productId == 2)
            {
                prod.CurrentPrice = 5.09m;
                prod.ProductName = "Dove";
                prod.ProductionDescription = "Bathing Soap";
            }

            Object myobj = new Object();
            Console.WriteLine($"Object: {myobj.ToString()}");
            Console.WriteLine($"Product: {prod.ToString()}");

            return prod;
        }

        /// <summary>
        /// Save a product
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanged)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        // Call an Insert Stored Procedure
                    }
                    else
                    {
                        // Call Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
