using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }

        
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }
        
    }
}
