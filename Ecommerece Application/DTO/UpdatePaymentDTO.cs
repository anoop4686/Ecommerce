using System.ComponentModel.DataAnnotations;

namespace Ecommerece_Application.DTO
{
    public class PaymentStatusDTO
    {
        [Required]
        public int PaymentId { get; set; }
        [Required]
        public string Status { get; set; }

    }
}
