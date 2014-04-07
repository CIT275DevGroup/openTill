using System.Collections.Generic;
using openTill.Domain.DTO;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  24 Feb 2014
//Revisions: 4/6/2014 Added Documentation | Curtis Reinhold

namespace openTill.Domain.Interface.Repository
{
    /// <summary>
    /// An interface that performs the CRUD operations for a brand object.
    /// </summary>
    public interface IBrandRepository
    {
        IEnumerable<BrandDTO> GetAll();
        void Insert(BrandDTO givenBrand);
        void Update(BrandDTO givenBrand);
        void Delete(BrandDTO givenBrand);
    }
}
