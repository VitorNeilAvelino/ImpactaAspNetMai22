using Marketplace.Repositorios.Http.Requests;
using System;
using System.ComponentModel.DataAnnotations;

namespace Marketplace.Mvc.Models
{
    public class PagamentoCreateViewModel
    {
        [Required]
        [Display(Name = "Cartão")]
        //[CreditCard] // promove a validação Luhn, obrigando a digitar um número de cartão válido.
        public string NumeroCartao { get; set; }

        [Required]
        [Display(Name = "Pedido")]
        public string NumeroPedido { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }

        internal static PagamentoRequest Mapear(PagamentoCreateViewModel viewModel)
        {
            var request = new PagamentoRequest();

            request.NumeroCartao = viewModel.NumeroCartao;
            request.NumeroPedido = viewModel.NumeroPedido;
            request.Valor = viewModel.Valor;
            request.Data = DateTime.Now;

            return request;
        }
    }
}