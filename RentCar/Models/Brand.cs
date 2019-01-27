using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }

        [Required]
        public string Description { get; set; }
        public bool State { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual ICollection<Model> Models { get; set; }
    }
}
