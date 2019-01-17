using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage ="El correo no cumple el formato valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La clave es obligatoria")]
        [MinLength(6,ErrorMessage = "La clave debe ser de almenos 6 caracteres")]
        [MaxLength(20, ErrorMessage = "La clave no puede ser mayor a 20 caracteres")]
        public string Password { get; set; }

        public ICollection<Role> Roles { get; set; }
    }
}
