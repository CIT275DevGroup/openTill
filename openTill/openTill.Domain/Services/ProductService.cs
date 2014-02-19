using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain.Services
{
    public class ProductService
    {
        public List<Product> GetAllProducts()
        {   
            List<Product> productList = new List<Product>();
            return productList;
        }
        public Product GetProductByUPC(string givenUPC)
        {
            Product newProduct = new Product();
            return newProduct;
        }
        public List<Product> GetProductsByBrand(string givenBrand)
        {
            List<Product> newProductList = new List<Product>();
            return newProductList;
        }

    }
}
