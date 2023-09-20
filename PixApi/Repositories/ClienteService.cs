using Microsoft.EntityFrameworkCore;
using PixApi.Data;
using PixApi.Domain.Models;
using PixApi.Dtos;
using PixApi.Interfaces;

namespace PixApi.Repositories
{
    public class ClienteService : IClienteService
    {
        private readonly ApplicationDbContext _appContext;

        public ClienteService(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<bool> CriarCliente(ClienteDto cliente)
        {
            if(PixExiste(cliente.chavePix) == true)
            {
                return false;
            }

            Cliente novoCliente = new Cliente()
            {
                ClienteNome = cliente.clienteNome,
                pix = new Pix()
                {
                    Chave = cliente.chavePix
                }
            };

            _appContext.Add(novoCliente);

            await _appContext.SaveChangesAsync();

            return await Save();
        }

        public async Task<bool> Save()
        {
            var saved = await _appContext.SaveChangesAsync();

            if (saved == 0) return true;

            return false;
        }

        public bool PixExiste(string chavePix)
        {
            if (_appContext.pix.FirstOrDefault(p => p.Chave == chavePix) != null)
            {
                return true;
            }
            
            else
                return false;
        }
    }
}
