using openTill.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain.Interface
{
    public interface IProductRepository
    {
        void Update(ProductDTO givenProduct);
        void Delete(ProductDTO givenProduct);
        void Create(ProductDTO givenProdcut);
        ProductDTO GetByUPC(string givenUPC);
        IEnumerable<ProductDTO> GetAll();
        IEnumerable<ProductDTO> GetByBrand(string givenBrand);
    }
}
