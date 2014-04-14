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
        /// <summary>
        /// Get a list of all brands
        /// </summary>
        /// <returns>List of Brands</returns>
        IEnumerable<BrandDTO> GetAll();
        /// <summary>
        /// Inserts a brand
        /// </summary>
        /// <param name="givenBrand">Brand</param>
        void Insert(BrandDTO givenBrand);
        /// <summary>
        /// Updates a brand
        /// </summary>
        /// <param name="givenBrand">Brand</param>
        void Update(BrandDTO givenBrand);
        /// <summary>
        /// Deletes a brand
        /// </summary>
        /// <param name="givenBrand">Brand</param>
        void Delete(BrandDTO givenBrand);
    }
}
