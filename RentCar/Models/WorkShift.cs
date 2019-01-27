using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class WorkShift
    {
        [Key]
        public int WorkShiftID { get; set; }

        [Required]
        public string Description { get; set; }
        public int WorkShiftHours { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
