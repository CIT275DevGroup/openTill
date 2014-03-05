using System.Collections.Generic;
using openTill.Domain.DTO;

namespace openTill.Domain.Interface.Service
{
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
        /// <param name="ssn">Social Security Number to be looked up.</param>
        /// <returns>Employee Data Transfer Object</returns>
        bool ValidateUser(string userName, string password);
    }
}