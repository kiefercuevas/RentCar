using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage ="El nombre es obligatorio")]
        [MinLength(3,ErrorMessage ="El nombre debe tener almenos 3 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage ="La cedula es obligatoria")]
        [StringLength(11,ErrorMessage ="El campo cedula debe tener 11 digitos")]
        [RegularExpression(@"^\d+$",ErrorMessage = "La cedula debe contener solo numeros")]
        public string IdentificationCard { get; set; }

        [Required(ErrorMessage = "La tarjeta de credito es obligatoria")]
        [StringLength(12, ErrorMessage = "La tarjeta de credito debe tener 12 digitos")]
        [RegularExpression(@"^\d+$", ErrorMessage = "La Tarjeta debe contener solo numeros")]
        public string CreditCardNumber { get; set; }

        
        public float CreditLimit { get; set; }

        public bool State { get; set; }

        public int PersonTypeId { get; set; }
        public virtual PersonType PersonType { get; set; }
        public virtual IEnumerable<Inspection> Inspections { get; set; }
    }
}
