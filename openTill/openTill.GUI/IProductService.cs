using openTill.Domain;
using System;
using System.Collections.Generic;
namespace openTill.GUI
{
    interface IProductService
    {
        List<openTill.Domain.Product> GetAllProducts();
        Product GetProductByUPC(string givenUPC);
        List<openTill.Domain.Product> GetProductsByBrand(string givenBrand);
    }
}
