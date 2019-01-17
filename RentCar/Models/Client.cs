using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string IdentificationCard { get; set; }
        public int CreditCardNumber { get; set; }
        public float CreditLimit { get; set; }
        public bool State { get; set; }
        public int PersonTypeId { get; set; }
        public virtual PersonType PersonType { get; set; }
        public virtual IEnumerable<Inspection> Inspections { get; set; }
    }
}
