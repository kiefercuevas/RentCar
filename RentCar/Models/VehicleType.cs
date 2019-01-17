using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class VehicleType
    {
        [Key]
        public int VehicleTypeId { get; set; }
        [Required(ErrorMessage ="El tipo de vehiculo es obligatorio")]
        public string Description { get; set; }
        public bool State { get; set; }
        public int RubberQuantity { get; set; }
        public virtual IEnumerable<Vehicle> Vehicles { get; set; }
    }
}
