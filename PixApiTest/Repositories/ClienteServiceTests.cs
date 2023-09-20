using NSubstitute;
using PixApi.Data;
using PixApi.Domain.Models;
using PixApi.Dtos;
using PixApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixApiTest.Repositories
{
    public class ClienteServiceTests
    {
        private readonly ClienteService _clienteService;
        
        public ClienteServiceTests()
        {
            var dbInMemory = new DbInMemory();
            var context = dbInMemory.GetContext();
            _clienteService = new ClienteService(context);
        }

        [Fact]
        public async Task CriarClienteRetornaTrue()
        {
            //Arrange
            var clienteDto = new ClienteDto()
            {
                clienteNome = "Teste",
                chavePix = "Teste@Gmail.com"
            };

            //Act
            var sucesso = await _clienteService.CriarCliente(clienteDto);

            //Assert
            Assert.True(sucesso);
        }
    }
}
