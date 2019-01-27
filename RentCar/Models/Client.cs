using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(11,ErrorMessage ="El campo cedula debe tener 11 digitos")]
        public string IdentificationCard { get; set; }

        [Required]
        [StringLength(12, ErrorMessage = "La tarjeta de credito debe tener 12 digitos")]
        public string CreditCardNumber { get; set; }

        public float CreditLimit { get; set; }

        public bool State { get; set; }

        public int PersonTypeID { get; set; }
        public virtual PersonType PersonType { get; set; }
        public virtual ICollection<IncomeAndRefund> IncomeAndRefunds { get; set; }
        public virtual ICollection<Inspection> Inspection { get; set; }
    }
}
