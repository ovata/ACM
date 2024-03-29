﻿using ACM.COMMON;
using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer : Base, ILoggable
    {

        public Customer() : this(0)
        {

        }

        public Customer(int custId)
        {
            CustomerId = custId;
            AddressList = new List<Address>();
        }

        public int CustomerId { get; private set; }
        public List<Address> AddressList { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }

        public string FullName
        {
            get 
            {
                string fullName = FirstName;
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += LastName;
                }
               return fullName; 
            }
        }

        public static int InstanceCount { get; set; }

        private string _lastname;

        public string LastName
        {
            get 
            { 
               return _lastname; 
            }
            set 
            { 
                _lastname = value;
            }
        }

        public string Log() => $"{CustomerId}: {FullName} Email: {Email} Status: {EntityState.ToString()}";

        public override string ToString() => FullName;

        /// <summary>
        /// validates the customer data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email)) isValid = false;
            return isValid;
        }

        /// <summary>
        /// Getting all customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetCustomers()
        {
            return new List<Customer>();
        }
    }
}
