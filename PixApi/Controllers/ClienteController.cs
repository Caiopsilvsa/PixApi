using Microsoft.AspNetCore.Mvc;
using PixApi.Dtos;
using PixApi.Interfaces;

namespace PixApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController:Controller
    {
        private readonly IClienteService _clienteService;
        private readonly ITransacaoService _transacaoService;
        
        public ClienteController(IClienteService clienteService, ITransacaoService transacaoService)
        {
            _clienteService = clienteService;
            _transacaoService = transacaoService;
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CriarCliente([FromBody]ClienteDto cliente)
        {
            if (cliente == null) return BadRequest(cliente);

            if (await _clienteService.CriarCliente(cliente) == true) 
            {
                return Ok(cliente);
            }  

            return BadRequest(cliente);        
        }

        [HttpPost("/pagamento")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Pagamento([FromBody] PagamentoRequestDto pagamentoRequest)
        {
            var result = await _transacaoService.Pagar(pagamentoRequest.pixEmissor, pagamentoRequest.pixRemetente, pagamentoRequest.valor);

            return Ok(result);
        }

        [HttpGet("/transacao/{pixCliente}")]
        public async Task<ActionResult> ObterTransacoesPorPix(string pixCliente)
        {
            var result = await _transacaoService.ObterTransacoesPorPix(pixCliente);

            return Ok(result);
        } 
    }
}
