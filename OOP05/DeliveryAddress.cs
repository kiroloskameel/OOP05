using System;
using System.Collections.Generic;
using System.Text;

namespace OOP05
{
    public class DeliveryAddress
    {
        public string Street { get; set; }
        public string City { get; set; }

        public DeliveryAddress(string street, string city)
        {
            Street = street;
            City = city;
        }
        public DeliveryAddress DeepCopy()
        {
            return new DeliveryAddress(Street, City);
        }
    }
}
