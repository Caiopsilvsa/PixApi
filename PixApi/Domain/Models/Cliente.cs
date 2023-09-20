using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace PixApi.Domain.Models
{
    public class Cliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }
        public string? ClienteNome { get; set; }
        public int Saldo { get; set; } = 1000;

        public virtual Pix pix { get; set; }
        public int pixId { get; set; }

    }
}
