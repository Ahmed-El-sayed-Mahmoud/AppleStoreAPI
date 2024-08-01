using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppleStoreAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [MaxLength(40)]
        public string ProductName { get; set; }
        [MaxLength(400)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public int Stock { get; set; }

        [MaxLength(50)]
        public string SKU { get; set; }
        public DateTime CreatedAt { get; set; }
        public Category category { get; set; }
        public int CategoryId { get; set; }
        public ICollection<Specification> specifications { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
