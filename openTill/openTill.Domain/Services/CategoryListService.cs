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
    class CategoryListService
    {
        #region Fields
        private readonly ICategoryListRepository _categoryListRepository;
        #endregion

        #region Constructors
        public CategoryListService(ICategoryListRepository categoryListRepository)
        {
            _categoryListRepository = categoryListRepository;
        }
        #endregion

        #region Methods

        public List<CategoryListDTO> GetAll()
        {
            var returnList = Mapper.Map<List<CategoryListDTO>>(_categoryListRepository.GetAll());
            return returnList;
        }

        public void Add(CategoryList categoryListItem)
        {
            var toAdd = Mapper.Map<CategoryListDTO>(categoryListItem);
            _categoryListRepository.Add(toAdd);
        }

        public void Remove(CategoryList categoryListItem)
        {
            var toRemove = Mapper.Map<CategoryListDTO>(categoryListItem);
            _categoryListRepository.Remove(toRemove);
        }

        public void Update(CategoryList categoryListItem)
        {
            var toUpdate = Mapper.Map<CategoryListDTO>(categoryListItem);
            _categoryListRepository.Update(toUpdate);
        }
        #endregion
    }
}
