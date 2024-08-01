using System.ComponentModel.DataAnnotations;

namespace AppleStoreAPI.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        [MaxLength(400)]
        public string ImageUrl {  get; set; }
        [MaxLength (200)]
        public string? Title { get; set; }
        public Product product { get; set; }
        public int ProductId { get; set; }
    }
}
