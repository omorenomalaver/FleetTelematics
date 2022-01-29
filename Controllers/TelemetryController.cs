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
    public class TelemetryController : ApiController
    {
        private TelemetryHelper telemetryHelper;

        public TelemetryController()
        {
            telemetryHelper = new TelemetryHelper();
        }

        //// GET: api/Telemetry
        public IEnumerable<TelemetryModel> Get()
        {
            var models = telemetryHelper.GetTelemetry(null);

            return models;
        }

        // GET: api/Telemetry/5
        public List<TelemetryModel> Get(int? id)
        {
            var models = telemetryHelper.GetTelemetry(id);

            return models;
        }

        // POST: api/Telemetry
        public void Post([FromBody]TelemetryModel value)
        {
            telemetryHelper.SetTelemetry(value);
        }
    }
}
