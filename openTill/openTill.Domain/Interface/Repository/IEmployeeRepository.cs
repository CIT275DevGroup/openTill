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
        /// <summary>
        /// Gets all employees
        /// </summary>
        /// <returns>List of Employees</returns>
        IEnumerable<EmployeeDTO> GetAll();
        /// <summary>
        /// Validates the user
        /// </summary>
        /// <param name="userName">Employee User Name</param>
        /// <param name="password">Employee Password</param>
        /// <returns></returns>
        bool ValidateUser(string userName, string password);
    }
}
