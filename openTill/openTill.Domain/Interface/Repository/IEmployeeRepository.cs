using System.Collections.Generic;
using openTill.Domain.DTO;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  24 Feb 2014
//Revisions:

namespace openTill.Domain.Interface.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<EmployeeDTO> GetAll();
        bool ValidateUser(string userName, string password);
    }
}
