using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class AddressRepo
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            if(addressId == 1)
            {
                address.Country = "Canada";
                address.State = "Ontario";
                address.StreetLine1 = "6th Ave";
                address.StreetLine2 = "West Coast";
                address.AddressType = 1;
                address.PostalCode = "167";
                address.City = "Citario";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int custId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Victoria Ave",
                StreetLine2 = "Flour Road",
                City = "Houston",
                State = "Texas",
                Country = "USA",
                PostalCode = "243"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Mike Street",
                StreetLine2 = "Wilton Road",
                City = "Atlanta",
                State = "Goergia",
                Country = "USA",
                PostalCode = "874"
            };

            addressList.Add(address);
            return addressList;
        }


        public bool Save(Address address)
        {
            var success = true;

            if (address.HasChanged)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
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
