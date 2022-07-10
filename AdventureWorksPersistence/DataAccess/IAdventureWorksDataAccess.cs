using AdventureWorksPersistence.Models;

namespace AdventureWorksPersistence.DataAccess
{
    public interface IAdventureWorksDataAccess
    {
        Task<List<Product>> GetProducts();
        Task<Product?> GetProductById(int id);
        Task<int> AddProduct(Product product);
        Task<bool> EditProduct(Product product,int id );
    }
}