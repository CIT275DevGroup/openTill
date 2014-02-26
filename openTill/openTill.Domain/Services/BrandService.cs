using AutoMapper;
using openTill.Domain.DTO;
using openTill.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  24 Feb 2014
//Revisions:

namespace openTill.Domain.Services
{
    public class BrandService
    {
        #region Fields
        private readonly IBrandRepository _brandRepository;
        #endregion

        #region Constructors

        /// <summary>
        /// Constructor that requires a repository as a parameter.
        /// </summary>
        /// <param name="brandRepository">Repository to be used.</param>
        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Method calls on repository to return a list of all Brands in the database
        /// </summary>
        /// <returns>List of Brand Data Transfer Objects</returns>
        public List<BrandDTO> GetAllBrands()
        {
            var brands = Mapper.Map<List<BrandDTO>>(_brandRepository.GetAll());
            return brands;
        }

        /// <summary>
        /// Method calls on repository to delete an existing brand in the database.
        /// </summary>
        /// <param name="givenBrand">Name of the brand to be deleted.</param>
        public void Delete(Brand givenBrand)
        {
            var brandToRemove = Mapper.Map<BrandDTO>(givenBrand);
            _brandRepository.Delete(brandToRemove);
        }

        /// <summary>
        /// Method calls on repository to insert a new brand into the database.
        /// </summary>
        /// <param name="givenBrand">Brand Data Transfer Object to be inserted into the database.</param>
        public void Insert(BrandDTO givenBrand)
        {
            var brandToCreate = Mapper.Map<BrandDTO>(givenBrand);
            _brandRepository.Insert(brandToCreate);
        }
        
        /// <summary>
        /// Method calls on repository to update an existing Brand in the database.
        /// </summary>
        /// <param name="givenBrand">Brand Data Transfer Object to the updated in the database.</param>
        public void Update(BrandDTO givenBrand)
        {
            var brandToUpdate = Mapper.Map<BrandDTO>(givenBrand);
            _brandRepository.Update(brandToUpdate);
        }

        #endregion
    }
}
