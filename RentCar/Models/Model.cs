using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class Model
    {
        [Key]
        public int ModelId { get; set; }
        [Required(ErrorMessage ="El modelo es obligatorio")]
        public string Description { get; set; }
        public bool State { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual IEnumerable<Vehicle> Vehicles { get; set; }
    }
}
