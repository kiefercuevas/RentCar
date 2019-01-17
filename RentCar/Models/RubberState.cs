﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class RubberState
    {
        [Key]
        public int RubberID { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }
        public virtual ICollection<Inspection> Inspections { get; set; }
    }
}
