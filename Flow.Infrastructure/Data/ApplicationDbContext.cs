using Flow.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Flow.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Shop> Shops { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public ShopState ShopState { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ShopState>().HasData(
                new ShopState
                {
                    Id = 1,
                    StateName = "Closed"
                },
                new ShopState
                {
                    Id = 2,
                    StateName = "Waiting For Verification"
                },
                new ShopState
                {
                    Id = 3,
                    StateName = "Working"
                }
            );
            
            builder.Entity<Address>().HasData(
                new Address
                {
                    Id = 1,
                    Longitude = "-122.4194",
                    Latitude = "37.7749",
                    AddressLine1 = "1 Market St",
                    AddressLine2 = "Suite 400",
                    City = "San Francisco",
                    State = "CA",
                    PostalCode = "94105",
                    Country = "USA"
                },
                new Address
                {
                    Id = 2,
                    Longitude = "-0.1276",
                    Latitude = "51.5074",
                    AddressLine1 = "10 Downing St",
                    AddressLine2 = "",
                    City = "London",
                    State = "",
                    PostalCode = "SW1A 2AA",
                    Country = "UK"
                },
                new Address
                {
                    Id = 3,
                    Longitude = "139.6917",
                    Latitude = "35.6895",
                    AddressLine1 = "1-1 Chiyoda",
                    AddressLine2 = "",
                    City = "Tokyo",
                    State = "Tokyo",
                    PostalCode = "100-8111",
                    Country = "Japan"
                },
                new Address
                {
                    Id = 4,
                    Longitude = "151.2093",
                    Latitude = "-33.8688",
                    AddressLine1 = "Sydney Opera House",
                    AddressLine2 = "Bennelong Point",
                    City = "Sydney",
                    State = "NSW",
                    PostalCode = "2000",
                    Country = "Australia"
                },
                new Address
                {
                    Id = 5,
                    Longitude = "2.3522",
                    Latitude = "48.8566",
                    AddressLine1 = "Eiffel Tower",
                    AddressLine2 = "Champ de Mars",
                    City = "Paris",
                    State = "Île-de-France",
                    PostalCode = "75007",
                    Country = "France"
                }
            );
        }
    }
}
