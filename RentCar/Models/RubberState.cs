using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class RubberState
    {
        [Key]
        public int RubberId;
        public string Description;
        public bool State;
        public virtual IEnumerable<Inspection> Inspections { get; set; }
    }
}
