using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FleetTelematics.Models
{
    public class TruckModel
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}