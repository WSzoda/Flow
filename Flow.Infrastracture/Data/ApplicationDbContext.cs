using Flow.Infrastracture.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Flow.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public ShopState ShopState { get; set; }
    }
}
