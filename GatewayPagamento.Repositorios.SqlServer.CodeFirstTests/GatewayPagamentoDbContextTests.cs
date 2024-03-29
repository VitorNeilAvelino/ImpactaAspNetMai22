﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using GatewayPagamento.Dominio.Entidades;

namespace GatewayPagamento.Repositorios.SqlServer.CodeFirst.Tests
{
    [TestClass()]
    public class GatewayPagamentoDbContextTests
    {
        [TestMethod()]
        public void InserirCartaoTeste()
        {
            var contexto = new GatewayPagamentoDbContext();

            contexto.Cartoes.Add(new Cartao { Numero = "1234123412341234", Limite = 1000 });
            contexto.SaveChanges();
        }
    }
}