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
    public interface IEmployeeRepository
    {
        void Insert(EmployeeDTO employee);
        void Delete(EmployeeDTO employee);
        void Update(EmployeeDTO employee);
        IEnumerable<EmployeeDTO> GetAll();
        IEnumerable<EmployeeDTO> GetByLastName(string lastName);
        EmployeeDTO GetBySSN(string ssn);
    }
}
