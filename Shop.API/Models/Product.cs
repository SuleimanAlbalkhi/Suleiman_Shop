using System.ComponentModel.DataAnnotations;

namespace shop.API.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string PictureUrl { get; set; }
        [Required]
        public string ProductType { get; set; }
        [Required]
        public string ProductBrand { get; set; }

    }
}