using System.Collections.Generic;
using GraphQL.Interfaces;
using GraphQL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GraphQL.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService; 
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAllProducts();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productService.GetProductById(id);
        }

        // POST api/values
        [HttpPost]
        public Product Post([FromBody] Product product)
        {
            _productService.AddProduct(product);
            return product;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Product Put(int id, [FromBody] Product product)
        {
            _productService.UpdateProduct(id, product);
            return product;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
