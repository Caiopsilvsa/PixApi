namespace PixApi.Dtos
{
    public class PagamentoResponsetDto
    {
        public string clienteRecebedor { get; set; }
        public string pixRecebedor { get; set; }
        public int saldoClienteRecebedor { get; set; }
        public string clientePagador { get; set; }
        public string pixPagador { get; set; }
        public int saldoClientePagador { get; set; }
    }
}
