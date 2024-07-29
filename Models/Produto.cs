using System;
using EcommerceApi.Enums;

namespace EcommerceApi.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string NumeroDoProduto { get; set; }
        public decimal ValorDoProduto { get; set; }

        public DateOnly DataCriacao { get; set; }
        public FormaDePagamento FormaDePagamento { get; set; }
        public Status Status { get; set; }
        
    }
}
