using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace carStoreManager.Models
{

    public class Car
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Item Name is required")]
        [StringLength(100, ErrorMessage = "Item Name cannot be longer than 100 characters")]
        public string? ItemName { get; set; }
        public string? CarModel { get; set; }
        public string? Brand { get; set; }
        public int? Quantity { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public string? Price { get; set; }
        public string? URL { get; set; }
        public string? Description { get; set; }
        public string? UserId { get; set; }
    }
}
