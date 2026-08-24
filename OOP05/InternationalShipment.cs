using System;
using System.Collections.Generic;
using System.Text;

namespace OOP05
{
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        public string DestinationCountry { get; set; }
        public decimal CustomsFee { get; set; }

        public override decimal EstimatedCost => DeliveryFee + (Weight * 5) + CustomsFee;

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine($"Tracking Code        : {TrackingCode}");
            Console.WriteLine($"Destination Country  : {DestinationCountry}");
            Console.WriteLine($"Estimated Cost       : {EstimatedCost} EGP");
        }

        public string GetTrackingStatus()
        {
            return TrackingStatus;
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }

        public override Shipment DeepCopy()
        {
            var copy = new InternationalShipment(TrackingCode, Description, Weight, DeliveryFee, Destination.DeepCopy(), DestinationCountry, CustomsFee);
            copy.TrackingStatus = this.TrackingStatus;
            return copy;
        }
    }
}
