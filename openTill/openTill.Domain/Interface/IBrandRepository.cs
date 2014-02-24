using openTill.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain.Interface
{
    interface IBrandRepository
    {
        IEnumerable<Brand> GetAll();
        void Create(BrandDTO givenBrand);
        void Update(BrandDTO givenBrand);
        void Delete(BrandDTO givenBrand);
    }
}
