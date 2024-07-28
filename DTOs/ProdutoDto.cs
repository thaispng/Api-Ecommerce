using EcommerceApi.Enums;

namespace EcommerceApi.DTOs
{
    public class ProdutoDto
    {
        public int Id { get; set; }
        public string NumeroDoProduto { get; set; }
        public decimal ValorDoProduto { get; set; }
        public string FormaDePagamento { get; set; }
        public string Status { get; set; }
    }
}
