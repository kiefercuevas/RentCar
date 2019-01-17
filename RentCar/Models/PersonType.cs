using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class PersonType
    {
        [Key]
        public int PersonTypeID { get; set; }
        [Required(ErrorMessage ="El tipo de persona es obligatorio")]
        public string Title { get; set; }
    }
}
