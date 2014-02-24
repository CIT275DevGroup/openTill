using AutoMapper;
using openTill.Domain.DTO;
using openTill.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain.Services
{
    class BrandService
    {
        #region Fields
        private readonly IBrandRepository _brandRepository;
        #endregion

        #region Constructors
        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        #endregion

        #region Methods

        public List<Brand> GetAllBrands()
        {
            var brands = Mapper.Map<List<Brand>>(_brandRepository.GetAll());
            return brands;
        }

        public void UpdateBrand(Brand givenBrand)
        {
            var brandToRemove = Mapper.Map<BrandDTO>(givenBrand);
            _brandRepository.Delete(brandToRemove);
        }

        public void CreateBrand(Brand givenBrand)
        {
            var brandToCreate = Mapper.Map<BrandDTO>(givenBrand);
            _brandRepository.Create(brandToCreate);
        }
        #endregion
    }
}
