using AutoMapper;
using openTill.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain.Services
{
    public class ProductService
    {
        #region Fields
        private readonly IProductRepository _productRepository;
        #endregion

        #region Constructors
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        #endregion

        #region Methods
        public List<Product> GetAllProducts()
        {
            var productList = Mapper.Map<List<Product>>(_productRepository.GetAll());
            return productList;
        }
        public Product GetProductByUPC(string givenUPC)
        {
            var newProduct = Mapper.Map<Product>(_productRepository.GetByUPC(givenUPC));
            return newProduct;
        }
        public List<Product> GetProductsByBrand(string givenBrand)
        {
            var productList = Mapper.Map<List<Product>>(_productRepository.GetByBrand(givenBrand));
            return productList;
        }
        #endregion

    }
}
