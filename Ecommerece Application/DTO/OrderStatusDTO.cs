using System.ComponentModel.DataAnnotations;

namespace Ecommerece_Application.DTO
{
    public class OrderStatusDTO
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public string Status { get; set; }

    }
}
