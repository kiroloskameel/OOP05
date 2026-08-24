using System;
using System.Collections.Generic;
using System.Text;

namespace OOP05
{
    public class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public override decimal EstimatedCost => DeliveryFee + (Weight * 5);

        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination) { }

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public string GetTrackingStatus()
        {
            return TrackingStatus;
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }

        public override Shipment DeepCopy()
        {
            var copy = new StandardShipment(TrackingCode, Description, Weight, DeliveryFee, Destination.DeepCopy());
            copy.TrackingStatus = this.TrackingStatus;
            return copy;
        }
    }
}
