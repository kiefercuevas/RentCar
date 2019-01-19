using System;
using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class IncomeAndRefund
    {
        [Key]
        public int IncomeID { get; set; }

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

        public int ClientID { get; set; }
        public Client Client { get; set; }

        public int VehicleID { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime IncomeDate { get; set; }
        public DateTime RefundDate { get; set; }
        public float AmountPerDay { get; set; }
        public int NumberOfDays { get; set; }
        public string Commentary { get; set; }
        public bool State { get; set; }
    }
}
