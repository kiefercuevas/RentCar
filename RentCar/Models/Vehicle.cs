using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleID { get; set; }

        [Required]
        public string Description { get; set; }

        /*https://www.pruebaderuta.com/numero-identificacion-vehicular.php
         *https://www.autodaewoospark.com/etiquetas-de-identificacion-vehicular.php
         * https://4.bp.blogspot.com/-Kg-Jq7yF_6g/VtSxTDjEr6I/AAAAAAAAJRQ/sgIRJgNOVEU/s1600/d0a051fe3339b8e5fd80342b4df59bee%2B%25281%2529.jpg
         *numero VIN o numero de chasis*/
        [Required]
        [StringLength(17,ErrorMessage ="El codigo del chasis debe ser de 17 digitos")]
        public string ChassisNumber { get; set; }

        [Required]
        public string EngineNumber { get; set; }

        [Required]
        public string LicensePlateNumber { get; set; }

        public int VehicleTypeID { get;set;}
        public virtual VehicleType VehicleType { get; set; }
        public int BrandID { get; set; }
        public virtual Brand Brand { get; set; }
        public int ModelID { get; set; }
        public virtual Model Model { get; set; }
        public int FluelTypeID { get; set; }
        public FluelType FluelType { get; set; }
        public bool State { get; set; }
        public bool IsRented { get; set; }
        public virtual ICollection<Inspection> Inspections { get; set; }
        public virtual ICollection<IncomeAndRefund> IncomeAndRefunds { get; set; }
    }
}
