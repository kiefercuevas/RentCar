using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
