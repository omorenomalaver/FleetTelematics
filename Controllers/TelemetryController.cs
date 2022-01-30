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
    /// <summary>
    /// Telemetry Information
    /// </summary>
    public class TelemetryController : ApiController
    {
        private TelemetryHelper telemetryHelper;

        /// <summary>
        /// Display and store telemetry data
        /// </summary>
        public TelemetryController()
        {
            telemetryHelper = new TelemetryHelper();
        }

        /// <summary>
        /// Get a list of telemetry filtering by truck id
        /// </summary>
        /// <param name="truckId">truck id, needs to be an integer number</param>
        /// <returns></returns>
        public List<TelemetryModel> Get(int? truckId)
        {
            var models = telemetryHelper.GetTelemetry(truckId);

            return models;
        }

        /// <summary>
        /// Store telemetry data
        /// </summary>
        /// <param name="value">telemetric data to be store</param>
        public void Post([FromBody]TelemetryModel value)
        {
            telemetryHelper.SetTelemetry(value);
        }
    }
}
