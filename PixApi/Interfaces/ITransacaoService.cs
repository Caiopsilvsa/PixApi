using PixApi.Domain.Models;
using PixApi.Dtos;

namespace PixApi.Interfaces
{
    public interface ITransacaoService
    {
        Task<PagamentoResponsetDto> Pagar(string pixEmissor, string pixRemetente, int valor);
        Task<Cliente> BuscarClientePorChavePix(string pixCliente);
        Task<List<Transacao>> ObterTransacoesPorPix(string pixCliente);

    }
}
