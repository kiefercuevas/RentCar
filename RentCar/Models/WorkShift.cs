using System.Collections.Generic;

namespace RentCar.Models
{
    public class WorkShift
    {
        public int WorkShiftId { get; set; }
        public string WorkShiftHour { get; set; }
        public virtual IEnumerable<Employee> Employees { get; set; }
    }
}
