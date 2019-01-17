using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class WorkShift
    {
        [Key]
        public int WorkShiftId { get; set; }

        [Required(ErrorMessage ="La tanda laboral es obligatoria")]
        public string Description { get; set; }
        [Range(4,8,ErrorMessage ="Las horas de trabajo deben estar entre 4 y 8 horas")]
        public int WorkShiftHour { get; set; }
        public virtual IEnumerable<Employee> Employees { get; set; }
    }
}
