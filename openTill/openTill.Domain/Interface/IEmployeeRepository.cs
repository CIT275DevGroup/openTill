using openTill.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain.Interface
{
    interface IEmployeeRepository
    {
        void Add(EmployeeDTO employee);
        void Remove(EmployeeDTO employee);
        void Update(EmployeeDTO employee);
        IEnumerable<EmployeeDTO> GetAll();
        IEnumerable<EmployeeDTO> GetByLastName(string lastName);
        EmployeeDTO GetBySSN(string ssn);
    }
}
