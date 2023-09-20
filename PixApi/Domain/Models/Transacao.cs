using System.ComponentModel.DataAnnotations.Schema;

namespace PixApi.Domain.Models
{
    public class Transacao
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransacaoId { get; set; }
        public Cliente? ClienteRecebedor { get; set; }
        public string PixClienteRecebedor { get; set; }
        public Cliente? ClientePagador { get; set; }
        public string PixClientePagador { get; set; }
        public int ValorDaTransacao { get; set; }
            
        DateTime? DataTransacao { get; set; } = DateTime.Now;
    }
}
