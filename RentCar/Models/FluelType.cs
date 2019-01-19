using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class FluelType
    {
        [Key]
        public int FluelTypeID { get; set; }
        [Required(ErrorMessage ="El tipo de combustible es obligatorio")]
        public string Description { get; set; }
        public bool State { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
