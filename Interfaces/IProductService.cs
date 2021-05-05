namespace GraphQL.Interfaces
{
    using System.Collections.Generic;
    using GraphQL.Models;

    public interface IProductService
    {
        Product AddProduct(Product product);
        void DeleteProduct(int id);
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        Product UpdateProduct(int id, Product product);
    }
}
