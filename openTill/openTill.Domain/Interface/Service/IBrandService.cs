using System.Collections.Generic;
using openTill.Domain.DTO;

namespace openTill.Domain.Interface.Service
{
    public interface IBrandService
    {
        /// <summary>
        /// Method calls on repository to return a list of all Brands in the database
        /// </summary>
        /// <returns>List of Brand Data Transfer Objects</returns>
        List<BrandDTO> GetAllBrands();

        /// <summary>
        /// Method calls on repository to delete an existing brand in the database.
        /// </summary>
        /// <param name="givenBrand">Name of the brand to be deleted.</param>
        void Delete(Brand givenBrand);

        /// <summary>
        /// Method calls on repository to insert a new brand into the database.
        /// </summary>
        /// <param name="givenBrand">Brand Data Transfer Object to be inserted into the database.</param>
        void Insert(BrandDTO givenBrand);

        /// <summary>
        /// Method calls on repository to update an existing Brand in the database.
        /// </summary>
        /// <param name="givenBrand">Brand Data Transfer Object to the updated in the database.</param>
        void Update(BrandDTO givenBrand);
    }
}