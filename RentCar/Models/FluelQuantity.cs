using System.ComponentModel.DataAnnotations;
namespace RentCar.Models
{
    public class FluelQuantity
    {
        [Key]
        public int FluelQuantityId { get; set; }
        public float Quantity { get; set; }
    }
}
