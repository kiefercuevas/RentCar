using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class RubberState
    {
        public int RubberId;
        public string Description;
        public bool State;
        public virtual IEnumerable<Inspection> Inspections { get; set; }
    }
}
