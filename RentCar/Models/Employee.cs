using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentCar.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MinLength(3, ErrorMessage = "El nombre debe tener almenos 3 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La cedula es obligatoria")]
        [StringLength(11, ErrorMessage = "El campo cedula debe tener 11 digitos")]
        [RegularExpression(@"^\d+$", ErrorMessage = "La cedula debe contener solo numeros")]
        public string IdentificationCard { get; set; }
        public int WorkShiftID { get; set; }
        public virtual WorkShift WorkShift { get; set; }
        public int CommissionPercentage { get; set; }
        public DateTime AdmissionDate { get; set; }
        public bool State { get; set; }
        public virtual ICollection<IncomeAndRefund> IncomeAndRefunds { get; set; }
        public virtual ICollection<Inspection> Inspections { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
