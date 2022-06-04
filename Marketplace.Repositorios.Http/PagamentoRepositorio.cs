﻿using Marketplace.Repositorios.Http.Requests;
using Marketplace.Repositorios.Http.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Repositorios.Http
{
    public class PagamentoRepositorio
    {
        private readonly HttpClient httpClient = new HttpClient();
        private const string caminho = "pagamentos";

        public PagamentoRepositorio(string baseAddress)
        {
            httpClient.BaseAddress = new Uri(baseAddress.Trim('/') + '/');
        }

        public async Task<List<PagamentoResponse>> ObterPorCartao(Guid guidCartao)
        {
            using (var resposta = await httpClient.GetAsync($"{caminho}/cartao/{guidCartao}"))
            {
                return await resposta.Content.ReadAsAsync<List<PagamentoResponse>>();
            }
        }

        public async Task Post(PagamentoRequest pagamento)
        {
            using (var resposta = await httpClient.PostAsJsonAsync(caminho, pagamento))
            {
                resposta.EnsureSuccessStatusCode();
            }
        }
    }
}
