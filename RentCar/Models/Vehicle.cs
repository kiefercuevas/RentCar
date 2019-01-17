using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string Description { get; set; }

        /*https://www.pruebaderuta.com/numero-identificacion-vehicular.php
         *https://www.autodaewoospark.com/etiquetas-de-identificacion-vehicular.php
         *numero VIN o numero de chasis*/
        public string ChassisNumber { get; set; }
        public string EngineNumber { get; set; }
        public string LicensePlateNumber { get; set; }

        public int VehicleTypeId {get;set;}
        public virtual VehicleType VehicleType { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public int ModelId { get; set; }
        public virtual Model Model { get; set; }
        public int FuelTypeId { get; set; }
        public FuelType FuelType { get; set; }
        public bool State { get; set; }

        public virtual IEnumerable<Inspection> Inspections { get; set; }
        public virtual IEnumerable<IncomeAndRefund> IncomeAndRefunds { get; set; }
    }
}
