using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class IncomeAndRefund
    {
        public int Incomeid { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime IncomeDate { get; set; }
        public DateTime RefundDate { get; set; }
        public float AmountPerDay { get; set; }
        public int NumberOfDays { get; set; }
        public string Commentary { get; set; }
        public bool State { get; set; }
    }
}
