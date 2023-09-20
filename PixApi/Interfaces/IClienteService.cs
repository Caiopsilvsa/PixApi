using PixApi.Domain.Models;
using PixApi.Dtos;

namespace PixApi.Interfaces
{
    public interface IClienteService
    {
        public Task<bool> CriarCliente(ClienteDto cliente);
    }
}
