using openTill.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain.Interface
{
    interface IProductRepository
    {
        void Update(ProductDTO givenProduct);
        void Delete(ProductDTO givenProduct);
        void Create(ProductDTO givenProdcut);
        void GetByUPC(string givenUPC);
        IEnumerable<ProductDTO> GetAll();  
    }
}
