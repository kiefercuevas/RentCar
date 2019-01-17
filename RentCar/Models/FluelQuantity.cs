using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class FluelQuantity
    {
        [Key]
        public int FluelQuantityID { get; set; }
        public float Quantity { get; set; }
    }
}
