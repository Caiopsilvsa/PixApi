using System.ComponentModel.DataAnnotations.Schema;

namespace PixApi.Domain.Models
{
    public class Pix
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PixId { get; set; }
        public string Chave { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}
