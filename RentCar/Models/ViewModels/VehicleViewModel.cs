using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models.ViewModels
{
    public class VehicleViewModel
    {
        public int VehicleID { get; set; }
        public string Description { get; set; }
        public string ChassisNumber { get; set; }
        public string EngineNumber { get; set; }
        public string LicensePlateNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string FluelType { get; set; }
        public string VehicleType { get; set; }
        public bool State { get; set; }
        public bool IsRented { get; set; }
    }
}
