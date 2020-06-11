using ACM.COMMON;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : Base, ILoggable
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

        private string _productName;

        public string ProductName
        {
            get 
            {
                return _productName.InsertSpaces();
            }
            set 
            { 
                _productName = value; 
            }
        }


        public override string ToString() => ProductName;

        public string Log() => $"{ProductId}: {ProductName} Detail: {ProductionDescription} Status: {EntityState.ToString()}";

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
