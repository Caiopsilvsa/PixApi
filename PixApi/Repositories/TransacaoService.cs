using Microsoft.EntityFrameworkCore;
using PixApi.Data;
using PixApi.Domain.Models;
using PixApi.Dtos;
using PixApi.Interfaces;

namespace PixApi.Repositories
{
    public class TransacaoService : ITransacaoService
    {
        private readonly ApplicationDbContext _appContext;

        public TransacaoService(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }
        public async Task<Cliente> BuscarClientePorChavePix(string pixCliente)
        {
            return await _appContext.clientes
                .Include(a => a.pix)
                .Where(a => a.pix.Chave == pixCliente)              
                .FirstAsync();                
        }

        public async Task<List<Transacao>> ObterTransacoesPorPix(string pixCliente)
        {
            var transacao = await _appContext.transasoes
                .Include(a => a.ClienteRecebedor)
                .Include(b => b.ClientePagador)
                .Include(a => a.ClienteRecebedor.pix)
                .Include(b => b.ClientePagador.pix)
                .Where(a => a.ClientePagador.pix.Chave == pixCliente)
                .ToListAsync();

            return transacao;   
        }

        public async Task<PagamentoResponsetDto> Pagar(string pixEmissor, string pixRemetente, int valor)
        {
            var clienteEmissor = await BuscarClientePorChavePix(pixEmissor);
            var clienteRemetente = await BuscarClientePorChavePix(pixRemetente);
                         
            clienteEmissor.Saldo -= valor;
            clienteRemetente.Saldo += valor;

            _appContext.clientes.UpdateRange(clienteEmissor, clienteRemetente);
            
            Transacao transacao = new()
            {
                ClientePagador = clienteEmissor,
                ClienteRecebedor = clienteRemetente,
                PixClientePagador = clienteEmissor.pix.Chave,
                PixClienteRecebedor = clienteEmissor.pix.Chave,
                ValorDaTransacao = valor
            };
            
            _appContext.transasoes.Add(transacao);
           
            await _appContext.SaveChangesAsync();

            PagamentoResponsetDto pagamento = new()
            {
                clientePagador = clienteEmissor.ClienteNome,
                clienteRecebedor = clienteRemetente.ClienteNome,
                pixPagador = clienteEmissor.pix.Chave,
                pixRecebedor = clienteRemetente.pix.Chave,
                saldoClientePagador = clienteEmissor.Saldo,
                saldoClienteRecebedor = clienteRemetente.Saldo
            };

            return pagamento; 
        }
    }
}
