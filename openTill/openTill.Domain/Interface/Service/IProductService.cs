using System.Collections.Generic;
using openTill.Domain.DTO;

namespace openTill.Domain.Interface.Service
{
    public interface IProductService
    {
        /// <summary>
        /// Method calls on repository to return a list of all Products from the database.
        /// </summary>
        /// <returns>Returns a list of Product Data Transfer Objects</returns>
        List<ProductDTO> GetAllProducts();

        /// <summary>
        /// Method calls on repository to return a single Product based on UPC code.
        /// </summary>
        /// <param name="givenUPC">The UPC used for lookup.</param>
        /// <returns>Returns a single Product Data Transfer Object.</returns>
        ProductDTO GetProductByUPC(string givenUPC);

        /// <summary>
        /// Method calls on repository to return a list of Products by Brand.
        /// </summary>
        /// <param name="givenBrand">Name of the brand for lookup.</param>
        /// <returns>Returns a list of Product Data Transfer Objects.</returns>
        List<ProductDTO> GetProductsByBrand(string givenBrand);
    }
}