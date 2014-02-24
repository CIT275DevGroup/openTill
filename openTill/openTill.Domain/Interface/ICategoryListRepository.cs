using openTill.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain.Interface
{
    interface ICategoryListRepository
    {
        IEnumerable<ICategoryListRepository> GetAll();
        void Add(CategoryListDTO categoryList);
        void Remove(CategoryListDTO categoryList);
        void Update(CategoryListDTO categoryList);
    }
}
