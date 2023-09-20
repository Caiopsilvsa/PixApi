using Microsoft.EntityFrameworkCore;
using PixApi.Domain.Models;

namespace PixApi.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Pix> pix { get; set; }
        public DbSet<Transacao> transasoes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pix>()
                .HasIndex(u => u.Chave)
                .IsUnique();
        }

    }
}
