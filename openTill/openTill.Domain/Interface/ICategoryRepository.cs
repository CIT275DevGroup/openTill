using openTill.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  24 Feb 2014
//Revisions:

namespace openTill.Domain.Interface
{
    public interface ICategoryRepository
    {
        void Update(CategoryDTO givenCategory);
        void Delete(CategoryDTO givenCategory);
        void Insert(CategoryDTO givenCategory);
        CategoryDTO GetByName(string givenName);
        IEnumerable<CategoryDTO> GetAll();
    }
}
