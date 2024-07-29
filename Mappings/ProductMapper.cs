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
            DataCriacao = produto.DataCriacao.ToString("dd/MM/yyyy"),
            ValorDoProduto = produto.ValorDoProduto,
            Status = produto.Status.ToString()
        };
    }
}
