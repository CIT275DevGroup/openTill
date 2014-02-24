using openTill.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain.Interface
{
    interface ICategoryRepository
    {
        void Update(CategoryDTO givenCategory);
        void Delete(CategoryDTO givenCategory);
        void Create(CategoryDTO givenCategory);
        CategoryDTO GetByName(string givenName);
        IEnumerable<CategoryDTO> GetAll();
    }
}
