using Infrastructure.Interface;
using Infrastructure.Models;

namespace Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products = new List<Product>
                       {
                        new Product(1,"Mi 11X Cosmic Black 6GB RAM 128GB ROM Storage",300,"_Processor: Qualcomm Snapdragon 870 5G with Kryo 585 Octa-core; 7nm process; Up to 3.2GHz clock speed; Liquidcool technology_Camera: 48 MP Triple Rear camera with 8MP Ultra-wide and 5MP Super macro | 20 MP Front camera_Display: 120Hz high refresh rate FHD+ (1080x2400) AMOLED Dot display; 16.9 centimeters (6.67 inch); 2.76mm ultra tiny punch hole; HDR 10+ support; 360Hz touch sampling, MEMC technology_Battery: 4520 mAH large battery with 33W fast charger in-box and Type-C connectivity.","https://m.media-amazon.com/images/I/71VQXjN6R7S._SL1500_.jpg"),
                        new Product(2,"Mi 11X Cosmic Black 6GB RAM 128GB ROM Storage",300,"_Processor: Qualcomm Snapdragon 870 5G with Kryo 585 Octa-core; 7nm process; Up to 3.2GHz clock speed; Liquidcool technology_Camera: 48 MP Triple Rear camera with 8MP Ultra-wide and 5MP Super macro | 20 MP Front camera_Display: 120Hz high refresh rate FHD+ (1080x2400) AMOLED Dot display; 16.9 centimeters (6.67 inch); 2.76mm ultra tiny punch hole; HDR 10+ support; 360Hz touch sampling, MEMC technology_Battery: 4520 mAH large battery with 33W fast charger in-box and Type-C connectivity.","https://m.media-amazon.com/images/I/71VQXjN6R7S._SL1500_.jpg"),
                        new Product(3,"Mi 11X Cosmic Black 6GB RAM 128GB ROM Storage",300,"_Processor: Qualcomm Snapdragon 870 5G with Kryo 585 Octa-core; 7nm process; Up to 3.2GHz clock speed; Liquidcool technology_Camera: 48 MP Triple Rear camera with 8MP Ultra-wide and 5MP Super macro | 20 MP Front camera_Display: 120Hz high refresh rate FHD+ (1080x2400) AMOLED Dot display; 16.9 centimeters (6.67 inch); 2.76mm ultra tiny punch hole; HDR 10+ support; 360Hz touch sampling, MEMC technology_Battery: 4520 mAH large battery with 33W fast charger in-box and Type-C connectivity.","https://m.media-amazon.com/images/I/71VQXjN6R7S._SL1500_.jpg"),
                        new Product(4,"Mi 11X Cosmic Black 6GB RAM 128GB ROM Storage",300,"_Processor: Qualcomm Snapdragon 870 5G with Kryo 585 Octa-core; 7nm process; Up to 3.2GHz clock speed; Liquidcool technology_Camera: 48 MP Triple Rear camera with 8MP Ultra-wide and 5MP Super macro | 20 MP Front camera_Display: 120Hz high refresh rate FHD+ (1080x2400) AMOLED Dot display; 16.9 centimeters (6.67 inch); 2.76mm ultra tiny punch hole; HDR 10+ support; 360Hz touch sampling, MEMC technology_Battery: 4520 mAH large battery with 33W fast charger in-box and Type-C connectivity.","https://m.media-amazon.com/images/I/71VQXjN6R7S._SL1500_.jpg"),
                        new Product(5,"Mi 11X Cosmic Black 6GB RAM 128GB ROM Storage",300,"_Processor: Qualcomm Snapdragon 870 5G with Kryo 585 Octa-core; 7nm process; Up to 3.2GHz clock speed; Liquidcool technology_Camera: 48 MP Triple Rear camera with 8MP Ultra-wide and 5MP Super macro | 20 MP Front camera_Display: 120Hz high refresh rate FHD+ (1080x2400) AMOLED Dot display; 16.9 centimeters (6.67 inch); 2.76mm ultra tiny punch hole; HDR 10+ support; 360Hz touch sampling, MEMC technology_Battery: 4520 mAH large battery with 33W fast charger in-box and Type-C connectivity.","https://m.media-amazon.com/images/I/71VQXjN6R7S._SL1500_.jpg"),
                        new Product(6,"Mi 11X Cosmic Black 6GB RAM 128GB ROM Storage",300,"_Processor: Qualcomm Snapdragon 870 5G with Kryo 585 Octa-core; 7nm process; Up to 3.2GHz clock speed; Liquidcool technology_Camera: 48 MP Triple Rear camera with 8MP Ultra-wide and 5MP Super macro | 20 MP Front camera_Display: 120Hz high refresh rate FHD+ (1080x2400) AMOLED Dot display; 16.9 centimeters (6.67 inch); 2.76mm ultra tiny punch hole; HDR 10+ support; 360Hz touch sampling, MEMC technology_Battery: 4520 mAH large battery with 33W fast charger in-box and Type-C connectivity.","https://m.media-amazon.com/images/I/71VQXjN6R7S._SL1500_.jpg"),
                       };

        private readonly ECommerceDBContext _dbContext;

        public ProductRepository(ECommerceDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void addNewProduct(Product product)
        {
           //_products.Add(product);
           _dbContext.Products.Add(product);
           _dbContext.SaveChanges();
        }
        public List<Product> getAllProducts()
        {
            // return _products;
            return _dbContext.Products.ToList();
        }
        public Product getProductById(int id)
        {
            //return _products.Find(item => item.Id == id);
            return _dbContext.Products.FirstOrDefault(item => item.Id == id) ?? new Product();
        }

    }
}
