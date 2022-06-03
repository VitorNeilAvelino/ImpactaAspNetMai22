using System.ComponentModel;

namespace GatewayPagamento.Dominio.Entidades
{
    public enum StatusPagamento
    {
        SaldoIndisponivel = 1,
        PedidoJaPago = 2,

        [Description("Cartão inexistente")]
        CartaoInexistente = 3,

        [Description("Pagamento OK")]
        PagamentoOK = 4
    }
}