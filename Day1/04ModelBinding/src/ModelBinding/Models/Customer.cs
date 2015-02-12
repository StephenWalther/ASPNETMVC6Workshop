using System;

namespace ModelBinding.Models
{
    public class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address BillingAddress { get; set; }

        public Address ShippingAddress { get; set; }
    }
}