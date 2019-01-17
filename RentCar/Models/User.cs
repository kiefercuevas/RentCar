using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class User
    {
        public int UserId { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public IEnumerable<Role> Roles { get; set; }
    }
}
