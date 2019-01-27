﻿using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class PersonType
    {
        [Key]
        public int PersonTypeID { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
