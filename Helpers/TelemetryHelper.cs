using FleetTelematics.Facades;
using FleetTelematics.Facades.ModelsDTO;
using FleetTelematics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FleetTelematics.Helpers
{
    public class TelemetryHelper
    {
        private TelemetryFacade telemetryFacade;
        private TruckFacade truckFacade;

        public TelemetryHelper()
        {
            telemetryFacade = new TelemetryFacade();
            truckFacade = new TruckFacade();
        }

        /// <summary>
        /// set new telemtry data into database
        /// </summary>
        /// <param name="telemetryModel"></param>
        public void SetTelemetry(TelemetryModel telemetryModel)
        {
            //check if telemetry id is already at the system
            var telemetries = telemetryFacade.GetTelemetries(new FilterDTO() { TelemetryId = telemetryModel.Id });
            if (telemetries.Any())
            {
                throw new ArgumentException("Telemetry id already exists", nameof(telemetryModel));
            }

            // check if truck exist 
            var truck = truckFacade.GetTrucks(new FilterDTO() { TruckId = telemetryModel.TruckId });

            if (truck.Any() == false)
            {
                throw new ArgumentException("Truck id does not exists", nameof(telemetryModel));
            }

            // map model into telemetry entity
            Telemetry telemetryEntity = new Telemetry()
            {
                Id = telemetryModel.Id,
                FkTruckId = telemetryModel.TruckId,
                OilPressure = telemetryModel.OilPressure,
                Speed = telemetryModel.Speed,
                Latitude = telemetryModel.Latitude,
                Longitude = telemetryModel.Longitude
            };

            // save telemetry
            telemetryFacade.SaveTelemetry(telemetryEntity);

        }

        /// <summary>
        /// get a list of telemetry data
        /// </summary>
        /// <param name="truckId">fitering by truck id, can be null, being null return all telemetry</param>
        /// <returns></returns>
        public List<TelemetryModel> GetTelemetry(int? truckId)
        {
            // filling up filtering
            FilterDTO telemetryFilterDTO = new FilterDTO()
            {
                TruckId = truckId
            };

            // getting telemetrics
            var telemetries = telemetryFacade.GetTelemetries(telemetryFilterDTO);
            List<TelemetryModel> models = new List<TelemetryModel>();

            // map telemetry filtering results
            foreach (Telemetry telemetry in telemetries.ToList())
            {
                TelemetryModel model = new TelemetryModel()
                {
                    Id = telemetry.Id,
                    OilPressure = telemetry.OilPressure,
                    Speed = telemetry.Speed,
                    TruckId = telemetry.FkTruckId,
                    Latitude = telemetry.Latitude,
                    Longitude = telemetry.Longitude
                };

                models.Add(model);
            }

            return models;
        }

    }
}