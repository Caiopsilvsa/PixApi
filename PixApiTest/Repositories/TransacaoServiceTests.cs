using PixApi.Dtos;
using PixApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixApiTest.Repositories
{
    public class TransacaoServiceTests
    {
        private readonly TransacaoService _transacaoService;

        public TransacaoServiceTests()
        {
            var dbInMemory = new DbInMemory();
            var context = dbInMemory.GetContext();
            _transacaoService = new TransacaoService(context);
        }

        [Fact]
       public async Task ObterTransacoesPorPixRetornaListaTransacoes()
        {
            //Arrange
            var pixCliente = "Maria@gmail.com";

            //Act
            var transacoes = await _transacaoService.ObterTransacoesPorPix(pixCliente);

            //Assert
            Assert.NotNull(transacoes);
            Assert.Equal(1, transacoes.Count());

        }

        [Fact]
        public async Task PagarRetornaResponseDto()
        {
            //Arrange
            var pixEmissor = "Joao@gmal.com";
            var pixRemetente = "Pedro@gmail.com";
            int valor = 200;

            //Act
            var result = await _transacaoService.Pagar(pixEmissor, pixRemetente, valor);

            //Assert
            Assert.IsType<PagamentoResponsetDto>(result);
            Assert.NotNull(result);
        }
    }
}
