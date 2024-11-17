using System.ComponentModel.DataAnnotations;

namespace Ecommerece_Application.DTO
{
    public class OrderDTO
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public List<OrderItemDetailsDTO> Items { get; set; }

    }
}
