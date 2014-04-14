using System.Collections.Generic;
using openTill.Domain.DTO;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  24 Feb 2014
//Revisions: 4/6/2014 Added Documentation | Curtis Reinhold

namespace openTill.Domain.Interface.Repository
{
    /// <summary>
    /// An interface that performs the CRUD operations for a Product
    /// </summary>
    public interface IProductRepository
    {
        /// <summary>
        /// Update a Product
        /// </summary>
        /// <param name="givenProduct">Produt</param>
        void Update(ProductDTO givenProduct);
        /// <summary>
        /// Delete a Product
        /// </summary>
        /// <param name="givenProduct">Product</param>
        void Delete(ProductDTO givenProduct);
        /// <summary>
        /// Insert a product
        /// </summary>
        /// <param name="givenProdcut">Product</param>
        void Insert(ProductDTO givenProdcut);
        /// <summary>
        /// Insert a product
        /// </summary>
        /// <param name="givenUPC">UPC</param>
        /// <returns></returns>
        ProductDTO GetByUPC(string givenUPC);
        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>List of products</returns>
        IEnumerable<ProductDTO> GetAll();
        /// <summary>
        /// Get a list of products by brand
        /// </summary>
        /// <param name="givenBrand">Brand</param>
        /// <returns>List of products by brand</returns>
        IEnumerable<ProductDTO> GetByBrand(string givenBrand);
    }
}
