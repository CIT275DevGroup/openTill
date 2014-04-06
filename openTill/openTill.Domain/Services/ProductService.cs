using AutoMapper;
using openTill.Domain.DTO;
using openTill.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  24 Feb 2014
//Revisions: 4/6/2014 Added/Edited(SaveProduct, RemoveProduct methods) Some Documentation | Curtis Reinhold

using openTill.Domain.Interface.Repository;
using openTill.Domain.Interface.Service;

namespace openTill.Domain.Services
{
    /// <summary>
    /// A road map that performs the CRUD operations for a Product
    /// </summary>
    public class ProductService : IProductService
    {
        #region Fields

        private readonly IProductRepository _productRepository;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor that requires a repository as a parameter.
        /// </summary>
        /// <param name="productRepository">Repository to be used.</param>
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method calls on repository to return a list of all Products from the database.
        /// </summary>
        /// <returns>Returns a list of Product Data Transfer Objects</returns>
        public List<ProductDTO> GetAllProducts()
        {
            var productList = Mapper.Map<List<ProductDTO>>(_productRepository.GetAll());
            return productList;
        }

        /// <summary>
        /// Method calls on repository to return a single Product based on UPC code.
        /// </summary>
        /// <param name="givenUPC">The UPC used for lookup.</param>
        /// <returns>Returns a single Product Data Transfer Object.</returns>
        public ProductDTO GetProductByUPC(string givenUPC)
        {
            var newProduct = Mapper.Map<ProductDTO>(_productRepository.GetByUPC(givenUPC));
            return newProduct;
        }

        /// <summary>
        /// Method calls on repository to return a list of Products by Brand.
        /// </summary>
        /// <param name="givenBrand">Name of the brand for lookup.</param>
        /// <returns>Returns a list of Product Data Transfer Objects.</returns>
        public List<ProductDTO> GetProductsByBrand(string givenBrand)
        {
            var productList = Mapper.Map<List<ProductDTO>>(_productRepository.GetByBrand(givenBrand));
            return productList;
        }
        /// <summary>
        /// Method calls on repository to save a Product.
        /// </summary>
        /// <param name="product">The Product to be saved.</param>
        public void SaveProduct(ProductDTO product)
        {
            _productRepository.Insert(product);
        }
        /// <summary>
        /// Method calls on repository to delete a Product.
        /// </summary>
        /// <param name="product">The Product to be deleted.</param>
        public void RemoveProduct(ProductDTO product)
        {
            _productRepository.Delete(product);
        }
        #endregion
    }
}
