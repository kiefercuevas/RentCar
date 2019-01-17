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
        public FluelQuantity FluelQuantity { get; set; }
        public bool HasReplacementRubber { get; set; }
        public bool HasLeverCat { get; set; }
        public bool HasGlassBreaks { get; set; }
        public string Etc { get; set; }
        public DateTime InspectionDate { get; set; }
        public bool State { get; set; }
        public virtual ICollection<RubberState> RubberStates { get; set; }
    }
}
