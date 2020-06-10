using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepo
    {
        public CustomerRepo()
        {
            addressRepo = new AddressRepo();
        }

        private AddressRepo addressRepo { get; set; }

        /// <summary>
        /// Retrieve a particular customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            Customer cust = new Customer(customerId);

            if (customerId == 1)
            {
                cust.Email = "test@test.com";
                cust.FirstName = "Biola";
                cust.LastName = "Ade";
                cust.AddressList = addressRepo.RetrieveByCustomerId(customerId).ToList();
            }

            return cust;
        }

        /// <summary>
        /// Save a new customer
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanged)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
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
