using EcommerceApi.DTOs;
using EcommerceApi.Models;

public static class ProductMapper
{
    public static ProdutoDto ToDto(Produto produto)
    {
        return new ProdutoDto
        {
            Id = produto.Id,
            NumeroDoProduto = produto.NumeroDoProduto,
            FormaDePagamento = produto.FormaDePagamento.ToString(),
            ValorDoProduto = produto.ValorDoProduto,
            Status = produto.Status.ToString()
        };
    }
}
