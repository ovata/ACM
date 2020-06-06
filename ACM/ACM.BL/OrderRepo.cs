using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepo
    {
        /// <summary>
        /// Getting a Order by Id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            Order ord = new Order(orderId);

            if (orderId == 11)
            {
                ord.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                                       new TimeSpan(7, 0, 0));
            }

            return ord;
        }

        /// <summary>
        /// Save a product
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            return true;
        }
    }
}
