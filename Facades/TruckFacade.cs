using FleetTelematics.Facades.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FleetTelematics.Facades
{
    public class TruckFacade
    {
        public List<Truck> GetTrucks(FilterDTO filterDTO)
        {
            List<Truck> trucks = new List<Truck>();

            using (FleetTelematicDBEntities1 db = new FleetTelematicDBEntities1())
            {
                if (filterDTO.TruckId.HasValue)
                {
                    trucks = db.Trucks.Where(x => x.Id == filterDTO.TruckId.Value).ToList();
                }
                else
                {
                    trucks = db.Trucks.ToList();
                }

            }

            return trucks;
        }

        public void SaveTrucks(Truck truck)
        {
            using (FleetTelematicDBEntities1 db = new FleetTelematicDBEntities1())
            {
                db.Trucks.Add(truck);
                db.SaveChanges();
            }
        }
    }
}