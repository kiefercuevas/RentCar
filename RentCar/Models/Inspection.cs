using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Inspection
    {
        public int InspectionId { get; set; }
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public bool HasGrazes { get; set; }
        public int FluelQuantityId { get; set; }
        public FluelQuantity FluelQuantity { get; set; }
        public bool HasReplacementRubber { get; set; }
        public bool HasLeverCat { get; set; }
        public bool HasGlassBreaks { get; set; }
        public string Etc { get; set; }
        public DateTime InspectionDate { get; set; }
        public bool State { get; set; }
        public virtual IEnumerable<RubberState> RubberStates { get; set; }
    }
}
