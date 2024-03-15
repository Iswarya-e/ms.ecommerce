using AutoMapper;
using Domain.Extensions;
using Domain.Interface;
using Domain.Models;
using Infrastructure.Interface;

namespace Domain.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IMapper _mapper;

        public ProductService(IProductRepository productRepo, IMapper mapper)
        {
            _productRepository = productRepo;
            _mapper = mapper;
        }
        public void addNewProduct(Product product)
        {
            //using Auto mapper
            //_productRepository.addNewProduct(_mapper.Map<Infrastructure.Models.Product>(product));
            //Mapping by creating new instance of destination object manually
             _productRepository.addNewProduct(ModelMapper.ConvertToRepoProducts(product));
        }

        public List<Product> getAllProducts()
        {
            var repoProducts = _productRepository.getAllProducts();
            var productsList = new List<Product>();
            foreach(var repoProduct in repoProducts)
            {
                //productsList.Add(_mapper.Map<Product>(repoProduct));
                productsList.Add(ModelMapper.ConvertToServiceProducts(repoProduct));
            }

            return productsList;
        }

        public Product getProductById(int id)
        {
            var newNumber = id.MutiplybyThree();
            //return _mapper.Map<Product>(_productRepository.getProductById(id));
            return ModelMapper.ConvertToServiceProducts(_productRepository.getProductById(id));
        }
    }
}
