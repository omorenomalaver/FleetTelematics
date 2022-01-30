using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FleetTelematics.Models
{
    public class TruckModel
    {
        /// <summary>
        /// truck id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// truck manufacturer, string
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// truck model, string
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// datetime truck was purchase
        /// </summary>
        public DateTime PurchaseDate { get; set; }
    }
}