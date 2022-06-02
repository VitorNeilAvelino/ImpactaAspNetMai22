using GatewayPagamento.Dominio.Entidades;
using GatewayPagamento.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatewayPagamento.Dominio.Servicos
{
    public class PagamentoServico
    {
        IPagamentoRepositorio pagamentoRepositorio;
        ICartaoRepositorio cartaoRepositorio;

        public PagamentoServico(IPagamentoRepositorio pagamentoRepositorio, ICartaoRepositorio cartaoRepositorio)
        {
            this.pagamentoRepositorio = pagamentoRepositorio;
            this.cartaoRepositorio = cartaoRepositorio;
        }

        public StatusPagamento Inserir(Pagamento pagamento)
        {
            var cartao = cartaoRepositorio.Selecionar(pagamento.Cartao.Numero);

            if (cartao == null)
            {
                return StatusPagamento.CartaoInexistente;
            }

            var pagamentoExistente = pagamentoRepositorio.Selecionar(p => p.NumeroPedido == pagamento.NumeroPedido);

            if (pagamentoExistente.Any())
            {
                return StatusPagamento.PedidoJaPago;
            }

            if (pagamento.Valor > cartao.Limite)
            {
                return StatusPagamento.SaldoIndisponivel;
            }

            pagamento.Status = StatusPagamento.PagamentoOK;

            pagamentoRepositorio.Inserir(pagamento);

            return StatusPagamento.PagamentoOK;
        }
    }
}
