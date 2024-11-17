using System.ComponentModel.DataAnnotations;

namespace Ecommerece_Application.DTO
{
    public class PaymentDTO
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string PaymentType { get; set; }


    }
}
