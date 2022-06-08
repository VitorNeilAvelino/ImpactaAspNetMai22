using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpoCenter.Repositorios.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using ExpoCenter.Dominio.Entidades;

namespace ExpoCenter.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class ExpoCenterDbContextTests
    {
        private readonly ExpoCenterDbContext dbContext;
        private readonly DbContextOptions<ExpoCenterDbContext> dbContextOptions;

        public ExpoCenterDbContextTests()
        {
            dbContextOptions = new DbContextOptionsBuilder<ExpoCenterDbContext>()
                .UseSqlServer(new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExpoCenter;Integrated Security=True"))
                .LogTo(ExibirQuery, LogLevel.Information)
                .Options;

            dbContext = new ExpoCenterDbContext(dbContextOptions);
        }

        private void ExibirQuery(string query)
        {
            Console.WriteLine(query);
        }

        [TestMethod()]
        public void InserirEventoTeste()
        {
            var evento = new Evento();
            evento.Local = "Qatar";
            evento.Data = new DateTime(2022, 11, 16);
            evento.Preco = 22.35m;
            evento.Descricao = "Copa do Mundo Fifa";
                        
            dbContext.Eventos.Add(evento);
            dbContext.SaveChanges();
        }
    }
}