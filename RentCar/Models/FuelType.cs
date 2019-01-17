using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class FuelType
    {
        [Key]
        public int FuelTypeId { get; set; }
        [Required(ErrorMessage ="El tipo de combustible es obligatorio")]
        public string Description { get; set; }
        public bool State { get; set; }
    }
}
