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
using openTill.Domain.Interface.Repository;
using openTill.Domain.Interface.Service;

namespace openTill.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        #region fields
        private readonly ICategoryRepository _categoryRepository;
        #endregion

        #region Constructors

        /// <summary>
        /// Constructor that requires a repository as a parameter.
        /// </summary>
        /// <param name="categoryRepository">Repository to be used.</param>
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Method calls on repository in the DAL to get all Category listing form the database.
        /// </summary>
        /// <returns>List of Category Data Transfer Objects.</returns>
        public List<CategoryDTO> GetAll()
        {
            var allCategories = Mapper.Map<List<CategoryDTO>>(_categoryRepository.GetAll());
            return allCategories;
        }

        /// <summary>
        /// Method calls on repository for a specific category from the database based on name.
        /// </summary>
        /// <param name="categoryName">The name of the category to retrieve.</param>
        /// <returns>Returns a Category Data Transfer Object.</returns>
        public CategoryDTO GetByName(string categoryName)
        {
            var category = Mapper.Map<CategoryDTO>(_categoryRepository.GetByName(categoryName));
            return category;
        }

        /// <summary>
        /// Method calls on repository to insert a new category field into the database.
        /// </summary>
        /// <param name="categoryToInsert">Category Data Transfer Object to insert into the database.</param>
        public void Insert(CategoryDTO categoryToInsert)
        {
            _categoryRepository.Insert(categoryToInsert);
        }

        /// <summary>
        /// Method calls on repository to update an exisiting field in the database.
        /// </summary>
        /// <param name="categoryToUpdate">Category that is to be updated.</param>
        public void Update(CategoryDTO categoryToUpdate)
        {
            _categoryRepository.Update(categoryToUpdate);
        }

        /// <summary>
        /// Method calls on repository to remove a Category field from the database.
        /// </summary>
        /// <param name="categoryToDelete">Category that is to be removed from the database.</param>
        public void Delete(CategoryDTO categoryToDelete)
        {
            _categoryRepository.Delete(categoryToDelete);
        }

        #endregion
    }
}
