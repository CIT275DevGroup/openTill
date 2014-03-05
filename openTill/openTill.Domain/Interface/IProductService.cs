using System;
namespace openTill.Domain.Services
{
    public interface IProductService
    {
        System.Collections.Generic.List<openTill.Domain.DTO.ProductDTO> GetAllProducts();
        openTill.Domain.DTO.ProductDTO GetProductByUPC(string givenUPC);
        System.Collections.Generic.List<openTill.Domain.DTO.ProductDTO> GetProductsByBrand(string givenBrand);
    }
}
