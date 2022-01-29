using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FleetTelematics.Models
{
    public class TelemetryModel
    {
        public int Id { get; set; }
        public int TruckId { get; set; }
        public decimal? OilPressure { get; set; }
        public decimal? Speed { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}