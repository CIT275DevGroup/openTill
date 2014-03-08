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

    #endregion

    public sealed class CategoryRepository : ICategoryRepository
    {
        #region [ Methods ]

        /// <summary>
        /// Returns all categories.
        /// </summary>
        /// <returns>IEnumerable of CategoryDTO</returns>
        public IEnumerable<CategoryDTO> GetAll()
        {
            IEnumerable<CategoryDTO> categories;

            using (var context = new openTillEntities())
            {
                categories = Mapper.Map<IEnumerable<CategoryDTO>>(context.Categories);
            }

            return categories;
        }

        /// <summary>
        /// Returns a category with a name matching the given name. Returns a null category if no match is found.
        /// </summary>
        /// <param name="name">Category name</param>
        /// <returns>CategoryDTO</returns>
        public CategoryDTO GetByName(string name)
        {
            // Throws an exception for invalid name value
            if (String.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("name",
                    "name does not accept a null or empty string as an argument.");

            CategoryDTO category;

            using (var context = new openTillEntities())
            {
                category = Mapper.Map<CategoryDTO>(context.Categories.SingleOrDefault(c => c.Name == name));

                // Throws an exception if the given category doesn't exist
                if (category == null)
                    throw new InvalidOperationException("No entry matching the given category was found.");
            }

            return category;
        }

        /// <summary>
        /// Submits a new category for persistence.
        /// </summary>
        /// <param name="newCategory">New category to save</param>
        public void Insert(CategoryDTO newCategory)
        {
            // Throws an exception for a null dto
            if (newCategory == null)
                throw new ArgumentNullException("newCategory",
                    "newCategory does not accept a null dto as an argument.");

            using (var context = new openTillEntities())
            {
                // Throws an exception if a category with the given name already exists
                if (context.Categories.SingleOrDefault(c => c.Name == newCategory.Name) != null)
                    throw new InvalidOperationException("A category with the given name already.");

                context.Categories.Add(Mapper.Map<Category>(newCategory));
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updates an existing category.
        /// </summary>
        /// <param name="categoryUpdate">Category to update</param>
        public void Update(CategoryDTO categoryUpdate)
        {
            // Throws an exception for a null dto
            if (categoryUpdate == null)
                throw new ArgumentNullException("categoryUpdate",
                    "categoryUpdate does not accept a null dto as an argument.");

            using (var context = new openTillEntities())
            {
                var category = context.Categories.SingleOrDefault(c => c.Id == categoryUpdate.Id);

                // Throws an exception if the given category doesn't exist
                if (category == null)
                    throw new InvalidOperationException("No entry matching the given category was found.");

                // Throws an exception if a category with the given name already exists
                if (context.Categories.SingleOrDefault(c => c.Name == categoryUpdate.Name) != null)
                    throw new InvalidOperationException("A category with the given name already.");

                // Update existing category
                category.Name = categoryUpdate.Name;
                category.Description = category.Description;

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Deletes a category.
        /// </summary>
        /// <param name="categoryDel">Category to delete</param>
        public void Delete(CategoryDTO categoryDel)
        {
            // Throws an exception for a null dto
            if (categoryDel == null)
                throw new ArgumentNullException("categoryDel",
                    "categoryDel does not accept a null dto as an argument.");

            using (var context = new openTillEntities())
            {
                var category = context.Categories.SingleOrDefault(c => c.Id == categoryDel.Id);

                // Throws an exception if no matching entry is found
                if (category == null)
                    throw new InvalidOperationException("No entry matching the given category was found.");

                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }

        #endregion
    }
}
