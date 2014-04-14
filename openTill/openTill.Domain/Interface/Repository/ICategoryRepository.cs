using System.Collections.Generic;
using openTill.Domain.DTO;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  24 Feb 2014
//Revisions: 4/6/2014 Added Documentation | Curtis Reinhold

namespace openTill.Domain.Interface.Repository
{
    /// <summary>
    /// An interface that performs the CRUD operations for a Category object
    /// </summary>
    public interface ICategoryRepository
    {
        /// <summary>
        /// Updates a category
        /// </summary>
        /// <param name="givenCategory">Category</param>
        void Update(CategoryDTO givenCategory);
        /// <summary>
        /// Deletes a category
        /// </summary>
        /// <param name="givenCategory">Category</param>
        void Delete(CategoryDTO givenCategory);
        /// <summary>
        /// Inserts a category
        /// </summary>
        /// <param name="givenCategory">Category</param>
        void Insert(CategoryDTO givenCategory);
        /// <summary>
        /// Get category by name
        /// </summary>
        /// <param name="givenName">name</param>
        /// <returns>Category</returns>
        CategoryDTO GetByName(string givenName);
        /// <summary>
        /// Gets all categories
        /// </summary>
        /// <returns>List of categories</returns>
        IEnumerable<CategoryDTO> GetAll();
    }
}
