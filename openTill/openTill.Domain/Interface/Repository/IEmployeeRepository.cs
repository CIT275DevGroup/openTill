using System.Collections.Generic;
using openTill.Domain.DTO;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  24 Feb 2014
//Revisions: 4/6/2014 Added Documentation | Curtis Reinhold

namespace openTill.Domain.Interface.Repository
{
    /// <summary>
    /// An interface that performs the CRUD operations for an Employee object
    /// </summary>
    public interface IEmployeeRepository
    {
        IEnumerable<EmployeeDTO> GetAll();
        bool ValidateUser(string userName, string password);
    }
}
