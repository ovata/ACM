using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {

        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Retrieve a particular order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Product Retrieve(int orderItemId)
        {
            return new Product();
        }

        /// <summary>
        /// Save the order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Validates
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (PurchasePrice == null) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (Quantity <= 0) isValid = false;

            return isValid;
        }
    }
}
