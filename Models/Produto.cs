using System.ComponentModel.DataAnnotations;

namespace EcommerceApi.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
