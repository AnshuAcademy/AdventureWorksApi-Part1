using AdventureWorksPersistence.Models;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorksPersistence.DataAccess
{
    public class AdventureWorksDataAccess : IAdventureWorksDataAccess
    {
        private readonly AdventureWorksDBContext context;

        public AdventureWorksDataAccess(AdventureWorksDBContext context)
        {
            this.context = context;
        }

        public async Task<int> AddProduct(Product product)
        {
            context.Add(product);
            await context.SaveChangesAsync();
            return product.ProductID;
        }

        public async Task<bool> EditProduct(Product product, int id)
        {
            var existingProduct = await context.Product.FindAsync(id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                await context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<Product?> GetProductById(int id)
        {
            return await context.Product.FindAsync(id);
        }

        public async Task<List<Product>> GetProducts()
        {
            return await context.Product.Take(20).ToListAsync();
        }
    }
}