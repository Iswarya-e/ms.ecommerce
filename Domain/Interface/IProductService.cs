
using Domain.Models;

namespace Domain.Interface
{
    public interface IProductService
    {
        List<Product> getAllProducts();
        Product getProductById(int id);
        void addNewProduct(Product product);
    }
}
