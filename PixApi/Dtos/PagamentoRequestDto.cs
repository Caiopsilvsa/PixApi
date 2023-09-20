namespace PixApi.Dtos
{
    public class PagamentoRequestDto
    {
        public string pixEmissor { get; set; } 
        public string pixRemetente { get; set; }
        public int valor { get; set; }
    }
}
