
namespace Domain.Extensions
{
    public static class ModelMapper
    {
        public static Infrastructure.Models.Product ConvertToRepoProducts(Models.Product product) {
            var newProduct = new Infrastructure.Models.Product(
                product.ProductId,
                product.ProductName,
                product.ProductPrice,
                product.ProductDetails,
                product.ProductImage);
            return newProduct;
        
        }

        public static Domain.Models.Product ConvertToServiceProducts(Infrastructure.Models.Product product)
        {
            var newProduct = new Models.Product(
                product.Id,
                product.Name,
                product.Price,
                product.Details,
                product.Image);
            return newProduct;

        }

        public static int MutiplybyThree (this int number)
        {
            return number * 3;
                
        }
    }
}
