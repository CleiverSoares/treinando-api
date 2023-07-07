using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Pessoa> Pessoas { get; set; }
        public virtual DbSet<Endereco> Enderecos { get; set; }
        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);

            Builder.Entity<Pessoa>()
              .HasMany(pessoa => pessoa.Enderecos)
              .WithOne(endereco => endereco.Pessoa)
              .HasForeignKey(endereco => endereco.PessoaId);

            Builder.Entity<Endereco>()
                .HasOne(endereco => endereco.Pessoa)
                .WithMany(pessoa => pessoa.Enderecos)
                .HasForeignKey(endereco => endereco.PessoaId);
        }
    }
}