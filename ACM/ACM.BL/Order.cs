using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order : Base
    {

        public Order() : this (0)
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public int CustomerType { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }


        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})"; 

        /// <summary>
        /// Validates
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
