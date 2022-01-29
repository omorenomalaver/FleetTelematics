using FleetTelematics.Facades.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FleetTelematics.Facades
{
    public class TelemetryFacade
    {
        /// <summary>
        /// get a list of telemetry
        /// </summary>
        /// <param name="filter">filtering</param>
        /// <returns></returns>
        public IEnumerable<Telemetry> GetTelemetries(FilterDTO filter)
        {
            // telemetry list returned
            List<Telemetry> telemetries = new List<Telemetry>();

            // open db connection
            using (FleetTelematicDBEntities1 db = new FleetTelematicDBEntities1())
            {
                // filtering by truck
                if (filter.TruckId.HasValue)
                {
                    telemetries = db.Telemetries.Include("Truck").Where(x => x.FkTruckId == filter.TruckId.Value).ToList();
                }
                else if (filter.TelemetryId.HasValue)
                {
                    telemetries = db.Telemetries.Include("Truck").Where(x => x.Id == filter.TelemetryId.Value).ToList();
                }
                // get all telemetry
                else
                {
                    telemetries = db.Telemetries.Include("Truck").ToList();
                }
            }

            // return telemetrics founded
            return telemetries;
        }

        /// <summary>
        /// this function save telemetry into database
        /// </summary>
        /// <param name="telemetry"></param>
        public void SaveTelemetry(Telemetry telemetry)
        {
            // open database
            using (FleetTelematicDBEntities1 db = new FleetTelematicDBEntities1())
            {
                // add new telemetry record
                db.Telemetries.Add(telemetry);
                //save
                db.SaveChanges();
            }
        }
    }
}