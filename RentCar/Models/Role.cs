﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
