using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {
                
        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductionDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
