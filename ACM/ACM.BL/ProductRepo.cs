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

            return prod;
        }

        /// <summary>
        /// Save a product
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            return true;
        }
    }
}
