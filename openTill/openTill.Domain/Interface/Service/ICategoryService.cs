using System.Collections.Generic;
using openTill.Domain.DTO;

namespace openTill.Domain.Interface.Service
{
    public interface ICategoryService
    {
        /// <summary>
        /// Method calls on repository in the DAL to get all Category listing form the database.
        /// </summary>
        /// <returns>List of Category Data Transfer Objects.</returns>
        List<CategoryDTO> GetAll();

        /// <summary>
        /// Method calls on repository for a specific category from the database based on name.
        /// </summary>
        /// <param name="categoryName">The name of the category to retrieve.</param>
        /// <returns>Returns a Category Data Transfer Object.</returns>
        CategoryDTO GetByName(string categoryName);

        /// <summary>
        /// Method calls on repository to insert a new category field into the database.
        /// </summary>
        /// <param name="categoryToInsert">Category Data Transfer Object to insert into the database.</param>
        void Insert(CategoryDTO categoryToInsert);

        /// <summary>
        /// Method calls on repository to update an exisiting field in the database.
        /// </summary>
        /// <param name="categoryToUpdate">Category that is to be updated.</param>
        void Update(CategoryDTO categoryToUpdate);

        /// <summary>
        /// Method calls on repository to remove a Category field from the database.
        /// </summary>
        /// <param name="categoryToDelete">Category that is to be removed from the database.</param>
        void Delete(CategoryDTO categoryToDelete);
    }
}