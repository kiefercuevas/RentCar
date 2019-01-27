using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentCar.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "El campo cedula debe tener 11 digitos")]
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
