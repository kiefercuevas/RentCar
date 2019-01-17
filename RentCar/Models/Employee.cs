using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string IdentificationCard { get; set; }
        public int WorkShiftId { get; set; }
        public virtual WorkShift WorkShift { get; set; }
        public int CommissionPercentage { get; set; }
        public DateTime AdmissionDate { get; set; }
        public bool State { get; set; }

        public virtual IEnumerable<IncomeAndRefund> IncomeAndRefunds { get; set; }
    }
}
