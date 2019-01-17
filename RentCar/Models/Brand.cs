using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }
        public virtual IEnumerable<Vehicle> Vehicles { get; set; }
        public virtual IEnumerable<Model> Models { get; set; }
    }
}
