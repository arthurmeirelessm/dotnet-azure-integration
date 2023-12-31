using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_with_cosmosdb.models
{
    public class Order
    {
        public string? Id { get; set; }

        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredData { get; set; }

        public DateTime? ShippedDate { get; set; }

        public int? ShipVia { get; set; }

        public double? Freight { get; set; }

        public string? ShipName { get; set; }

        public string? ShipAddress { get; set; }

        public string? ShipCity { get; set; }

        public string? ShipRegion { get; set; }

        public string? ShipPostalCode { get; set; }

        public string? ShipCountry { get; set; }
    }
}