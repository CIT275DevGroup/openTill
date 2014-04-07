using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using openTill.Domain.DTO;
using openTill.Domain.Interface;
using openTill.Domain.Interface.Repository;

namespace openTill.Persistence
{
    // Author: Ryan Redburn
    // Project: openTill
    // Date: 2/25/2014

    #region [ Updates ]

    // Author: Ryan Redburn
    // Date: 3/4/2014
    // Revisions: Fixed minor logic and spelling errors. Added some additional exception handling.
    // Revisions: 4/6/2014 Added Some Documentation | Curtis Reinhold

    #endregion
    /// <summary>
    /// The class that actually performs the CRUD operations of a Brand.
    /// </summary>
    public sealed class BrandRepository : IBrandRepository
    {
        #region [ Methods ]

        /// <summary>
        /// Returns all brands.
        /// </summary>
        /// <returns>IEnumerable of BrandDTO</returns>
        public IEnumerable<BrandDTO> GetAll()
        {
            IEnumerable<BrandDTO> brands;

            using (var context = new openTillEntities())
            {
                brands = Mapper.Map<IEnumerable<BrandDTO>>(context.Brands);
            }

            return brands;
        }

        /// <summary>
        /// Submits a new brand for persistence.
        /// </summary>
        /// <param name="newBrand">New brand to save.</param>
        public void Insert(BrandDTO newBrand)
        {
            // Throws an an exception for a null dto
            if (newBrand == null)
                throw new ArgumentNullException("newBrand",
                    "newBrand does not accept a null dot as an argument.");

            using (var context = new openTillEntities())
            {
                // Throws an exception if a brand with the given name already exists
                if (context.Brands.SingleOrDefault(b => b.Name == newBrand.Name) != null)
                    throw new InvalidOperationException("A brand with the given brand name already exists.");

                context.Brands.Add(Mapper.Map<Brand>(newBrand));
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updates an existing brand.
        /// </summary>
        /// <param name="brandUpdate">Brand to update</param>
        public void Update(BrandDTO brandUpdate)
        {
            // Throws an an exception for a null dto
            if (brandUpdate == null)
                throw new ArgumentNullException("brandUpdate",
                    "brandUpdate does not accept a null dot as an argument.");

            using (var context = new openTillEntities())
            {
                var brand = context.Brands.SingleOrDefault(b => b.Id == brandUpdate.Id);

                // Throws an exception if the given brand doesn't exist
                if (brand == null)
                    throw new InvalidOperationException("No entry matching the given brand was found.");

                // Throws an exception if a brand with the given name already exists
                if (context.Brands.SingleOrDefault(b => b.Name == brandUpdate.Name) != null)
                    throw new InvalidOperationException("A brand with the given brand name already exists.");

                // Update existing brand
                brand.Name = brandUpdate.Name;

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Deletes a brand.
        /// </summary>
        /// <param name="brandDel">Brand to delete</param>
        public void Delete(BrandDTO brandDel)
        {
            // Throws an an exception for a null dto
            if (brandDel == null)
                throw new ArgumentNullException("brandDel",
                    "brandDel does not accept a null dot as an argument.");

            using (var context = new openTillEntities())
            {
                var brand = context.Brands.SingleOrDefault(b => b.Id == brandDel.Id);

                // Throws an exception if no matching entry is found
                if (brand == null)
                    throw new InvalidOperationException("No entry matching the given brand was found.");

                context.Brands.Remove(brand);
                context.SaveChanges();
            }
        }

        #endregion
    }
}
