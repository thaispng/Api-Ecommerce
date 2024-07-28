using Microsoft.EntityFrameworkCore;
using EcommerceApi.Models;
using EcommerceApi.Enums;

namespace EcommerceApi.Data
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options) { }

        public DbSet<Login> Logins { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .Property(p => p.FormaDePagamento)
                .HasConversion<string>();

            modelBuilder.Entity<Produto>()
                .Property(p => p.Status)
                .HasConversion<string>();
        }
    }
}
