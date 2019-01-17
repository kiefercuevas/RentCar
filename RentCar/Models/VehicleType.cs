using System.Collections.Generic;

namespace RentCar.Models
{
    public class VehicleType
    {
        public int VehicleTypeId { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }
        public int RubberQuantity { get; set; }
        public virtual IEnumerable<Vehicle> Vehicles { get; set; }
    }
}
