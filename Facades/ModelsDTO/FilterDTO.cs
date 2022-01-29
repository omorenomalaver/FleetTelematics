using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FleetTelematics.Facades.ModelsDTO
{
    public class FilterDTO
    {
        public int? TruckId { get; set; }
        public int? TelemetryId { get; set; }
    }
}