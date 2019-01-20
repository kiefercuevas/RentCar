using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class Inspection
    {
        [Key]
        public int InspectionID { get; set; }
        public int VehicleID { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public bool HasGrazes { get; set; }
        public int FluelQuantityID { get; set; }
        public virtual FluelQuantity FluelQuantity { get; set; }
        public bool HasReplacementRubber { get; set; }
        public bool HasLeverCat { get; set; }
        public bool HasGlassBreaks { get; set; }
        public string Etc { get; set; }
        public DateTime InspectionDate { get; set; }
        public bool State { get; set; }
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
        public int IncomeID { get; set; }
        public virtual IncomeAndRefund IncomeAndRefund { get; set; }
        public virtual ICollection<RubberState> RubberStates { get; set; }
    }
}
