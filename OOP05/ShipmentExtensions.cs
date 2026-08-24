using System;
using System.Collections.Generic;
using System.Text;

namespace OOP05
{
    public static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            string typeName = shipment.GetType().Name.Replace("Shipment", "").Trim();
            if (string.IsNullOrEmpty(typeName)) typeName = "Standard";

            return $"{shipment.TrackingCode} | {typeName} | {shipment.Weight} KG | {shipment.TrackingStatus}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.TrackingStatus.Equals("Delivered", System.StringComparison.OrdinalIgnoreCase);
        }
    }
}
