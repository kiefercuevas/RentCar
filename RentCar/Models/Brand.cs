using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }

        [Required(ErrorMessage ="La descripcion es obligatoria")]
        public string Description { get; set; }
        public bool State { get; set; }
        public virtual IEnumerable<Vehicle> Vehicles { get; set; }
        public virtual IEnumerable<Model> Models { get; set; }
    }
}
