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
        public void Post([FromBody]TruckModel truck)
        {
            var truckHelper = new TruckHelper();
            truckHelper.SetTruck(truck);
        }
    }
}
