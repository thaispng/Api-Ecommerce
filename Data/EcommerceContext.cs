using Microsoft.EntityFrameworkCore;
using EcommerceApi.Models;

namespace EcommerceApi.Data
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options) { }

        public DbSet<Login> Logins { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
