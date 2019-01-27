using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class Model
    {
        [Key]
        public int ModelID { get; set; }
        [Required]
        public string Description { get; set; }
        public bool State { get; set; }
        public int BrandID { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
