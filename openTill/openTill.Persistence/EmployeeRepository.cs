using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using AutoMapper;
using openTill.Domain.DTO;
using openTill.Domain.Interface;
using openTill.Domain.Interface.Repository;
using System.Diagnostics.CodeAnalysis;

namespace openTill.Persistence
{
    // Author: Ryan Redburn
    // Project: openTill
    // Date: 3/5/2014
    // Revisions: 4/6/2014 Added Documentation | Curtis Reinhold

    /// <summary>
    /// A class that actually performs the CRUD operations for an Employee. 
    /// </summary>
    public sealed class EmployeeRepository : IEmployeeRepository
    {
        #region [ Methods ]

        /// <summary>
        /// Returns all employees.
        /// </summary>
        /// <returns>IEnumerable of EmployeeDto</returns>
        [ExcludeFromCodeCoverage]
        public IEnumerable<EmployeeDTO> GetAll()
        {
            IEnumerable<EmployeeDTO> employees;

            using (var context = new openTillEntities())
            {
                employees = Mapper.Map<IEnumerable<EmployeeDTO>>(context.Employees);
            }

            return employees;
        }

        /// <summary>
        /// Validates an employee by confirming that the given password matches the password associated with the given username.
        /// </summary>
        /// <param name="userName">String username</param>
        /// <param name="password">String password</param>
        /// <returns>Bool authenticated</returns>
        [ExcludeFromCodeCoverage]
        public bool ValidateUser(string userName, string password)
        {
            Employee employee;

            // Creates a guid for comparison using the given password
            var empGuid = new Guid(SHA256.Create().ComputeHash(Encoding.Unicode.GetBytes(password)));

            using (var context = new openTillEntities())
            {
                // Looks for an employee with the given username and password(comparison made using guid)
                employee = context.Employees.SingleOrDefault(e => e.UserName == userName && e.PasswordHash == empGuid);
            }

            return employee != null;
        }

        #endregion
    }
}
