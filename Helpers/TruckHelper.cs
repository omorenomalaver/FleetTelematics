using FleetTelematics.Facades;
using FleetTelematics.Facades.ModelsDTO;
using FleetTelematics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FleetTelematics.Helpers
{
    public class TruckHelper
    {
        private TruckFacade truckFacade;

        public TruckHelper()
        {
            truckFacade = new TruckFacade();
        }

        /// <summary>
        /// this function set truck info to be store at database
        /// </summary>
        /// <param name="truckModel"></param>
        public void SetTruck(TruckModel truckModel)
        {
            // check if truck exist 
            var truck = truckFacade.GetTrucks(new FilterDTO() { TruckId = truckModel.Id });

            // if query return any value
            if (truck.Any() == true)
            {
                throw new ArgumentException(string.Format("Truck id {0} already exists", truckModel.Id), nameof(truckModel.Id), null);
            }

            // map truck model at truck entity
            Truck truckEntity = new Truck()
            {
                Id = truckModel.Id,
                Manufacturer = truckModel.Manufacturer,
                Model = truckModel.Model,
                PurchaseDate = truckModel.PurchaseDate
            };

            // save truck at db
            truckFacade.SaveTrucks(truckEntity);

        }
    }
}