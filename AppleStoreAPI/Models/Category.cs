using System.ComponentModel.DataAnnotations;

namespace AppleStoreAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }

        [MaxLength (400)]
        public string? Description { get; set; }
    }
}
