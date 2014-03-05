using System.Collections.Generic;
using openTill.Domain.DTO;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  24 Feb 2014
//Revisions:

namespace openTill.Domain.Interface.Repository
{
    public interface IBrandRepository
    {
        IEnumerable<BrandDTO> GetAll();
        void Insert(BrandDTO givenBrand);
        void Update(BrandDTO givenBrand);
        void Delete(BrandDTO givenBrand);
    }
}
