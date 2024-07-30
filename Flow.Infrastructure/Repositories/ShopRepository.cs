using System.Collections;
using Flow.Core.Entities;
using Flow.Core.Interfaces.Repositories;
using Flow.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Flow.Infrastructure.Repositories
{
    public class ShopRepository : IShopRepository
    {
        private readonly ApplicationDbContext _context;
        
        public ShopRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task AddShopAsync(Shop shop)
        {
            ArgumentNullException.ThrowIfNull(shop);

            await _context.Shops.AddAsync(shop);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteShopAsync(long shopId)
        {
            var shop = await _context.Shops.FirstOrDefaultAsync(shop => shop.Id == shopId);
            ArgumentNullException.ThrowIfNull(shop);

            _context.Remove(shop);

            await _context.SaveChangesAsync();
        }

        public IQueryable<Shop> GetAllShops()
        {
            var shops =  _context.Shops.AsNoTracking().Include("Address").AsQueryable();
            return shops;
        }

        public async Task<Shop> GetShopWithIdAsync(long shopId)
        {
            var shop = await _context.Shops.AsNoTracking().FirstOrDefaultAsync(shop => shop.Id == shopId);
            ArgumentNullException.ThrowIfNull(shop);

            return shop!;
        }

        public async Task UpdateShopAsync(Shop shop)
        {
            var shopOriginal = await _context.Shops.AsNoTracking().FirstOrDefaultAsync(shopQ => shopQ.Id == shop.Id);
            ArgumentNullException.ThrowIfNull(shopOriginal);

            _context.Shops.Update(shop);
            await _context.SaveChangesAsync(true);
        }
    }
}
