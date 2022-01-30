using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FleetTelematics.Models
{
    public class TelemetryModel
    {
        /// <summary>
        /// telemetry id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// truck id associate to this telemetry data
        /// </summary>
        public int TruckId { get; set; }
        
        /// <summary>
        /// oil pressure in psi of the truck
        /// </summary>
        public decimal? OilPressure { get; set; }

        /// <summary>
        /// speed in kilometres
        /// </summary>
        public decimal? Speed { get; set; }

        /// <summary>
        /// latitude in double 
        /// </summary>
        public double? Latitude { get; set; }

        /// <summary>
        /// Longitude in double
        /// </summary>
        public double? Longitude { get; set; }
    }
}