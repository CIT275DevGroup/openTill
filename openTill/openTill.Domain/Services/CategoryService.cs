using AutoMapper;
using openTill.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain.Services
{
    class CategoryService
    {
        #region fields
        private readonly ICategoryRepository _categoryRepository;
        #endregion

        #region Constructors
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        #endregion

        #region Methods
        public List<Category> GetAll()
        {
            var allCategories = Mapper.Map<List<Category>>(_categoryRepository.GetAll());
            return allCategories;
        }
        #endregion
    }
}
