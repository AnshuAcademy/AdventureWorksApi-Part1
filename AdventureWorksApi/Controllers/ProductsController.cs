using AdventureWorksPersistence.DataAccess;
using AdventureWorksPersistence.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IAdventureWorksDataAccess data;

        public ProductsController(IAdventureWorksDataAccess data)
        {
            this.data = data;
        }

        [HttpGet("GetProducts")]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await data.GetProducts());

        }

        [HttpGet("GetProductByID")]
        public async Task<IActionResult> GetProductByID(int id)
        {
            return Ok(await data.GetProductById(id));

        }

        [HttpPost("AddProduct")]
        public async Task<int> AddProduct(Product product)
        {
            return await data.AddProduct(product);
        }

        [HttpPut("EditProduct")]
        public async Task<bool> EditProduct(Product product,int id)
        {
            return await data.EditProduct(product, id);
        }

    }
}
