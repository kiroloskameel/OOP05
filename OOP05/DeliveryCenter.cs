using System;
using System.Collections.Generic;
using System.Text;

namespace OOP05
{
    public class DeliveryCenter
    {
        public string CenterName { get; set; }
        private Shipment[] _shipments;
        private int _count;

        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
            _shipments = new Shipment[20];
            _count = 0;
        }

        public bool AddShipment(Shipment shipment)
        {
            if (_count >= 20) return false;
            _shipments[_count] = shipment;
            _count++;
            return true;
        }

        public void PrintAllShipments()
        {
            DeliveryUtilities.PrintSystemTitle($"Delivery Center : {CenterName}");

            for (int i = 0; i < _count; i++)
            {
                _shipments[i].PrintShipment();
                Console.WriteLine("------------------------------------------");
            }
        }
    }
}
