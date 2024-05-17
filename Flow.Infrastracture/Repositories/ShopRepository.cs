using Flow.Contracts.Dtos.Shop;
using Flow.Infrastracture.Entities;
using Flow.Infrastracture.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.DataAccess.Repositories
{
    public class ShopRepository : IShopRepository
    {
        private readonly ApplicationDbContext _context;
        public ShopRepository(ApplicationDbContext context)
        {
            _context = context;
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

        public async Task<List<Shop>> GetShopsAsync()
        {
            var shops = await _context.Shops.AsNoTracking().ToListAsync();
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
