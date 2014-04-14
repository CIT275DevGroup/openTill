using System.Collections.Generic;
using openTill.Domain.DTO;

// Revision: 4/6/2014 Added Some Documentation | Curtis Reinhold

namespace openTill.Domain.Interface.Service
{
    /// <summary>
    /// An interface that calls on the IEmployeeRepository to perform CRUD operations.
    /// </summary>
    public interface IEmployeeService
    {
        /// <summary>
        /// Method calls on repositorty to return a list of all Employees from the database.
        /// </summary>
        /// <returns>Returns a list of all Employees in the database, in the form of Data Transfer Objects.</returns>
        List<EmployeeDTO> GetAll();

        /// <summary>
        /// Method calls on repository to return a single Employee from the database based on SSN.
        /// </summary>
        /// <param name="userName">Username of the employee.</param>
        /// <param name="password">Password of the employee.</param>
        /// <returns>Employee Data Transfer Object</returns>
        bool ValidateUser(string userName, string password);
    }
}