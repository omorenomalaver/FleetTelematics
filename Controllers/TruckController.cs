using FleetTelematics.Helpers;
using FleetTelematics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FleetTelematics.Controllers
{
    public class TruckController : ApiController
    {
        // POST: api/Truck

        /// <summary>
        /// store truck data
        /// </summary>
        /// <param name="truck">truck data to be store</param>
        public void Post([FromBody]TruckModel truck)
        {
            var truckHelper = new TruckHelper();
            truckHelper.SetTruck(truck);
        }
    }
}
