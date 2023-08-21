using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using NLayer.Core.DTOs;
using NLayer.Core.Repositories;

namespace NLayer.Respository.Repositories
{
    public class ProductRepository : GenericRepositories<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductsWitCategory()
        {

            return await _context.Products.Include(x => x.Category).ToListAsync();
        }
    }
}
