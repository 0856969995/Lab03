using System.ComponentModel.DataAnnotations;

namespace Lab03.Models
{
    public class Product
    {
        //Id tu dong gan khoa chinh
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Range(0.01, 10000.00)]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }// dau ? cho phep null
        public List<ProductImage>? Images { get; set; }
        //xay dung khoa ngoai
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
