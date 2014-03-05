using AutoMapper;
using openTill.Domain.DTO;
using openTill.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  24 Feb 2014
//Revisions:

namespace openTill.Domain.Services
{
    public class EmployeeService
    {
        #region Fields
        private readonly IEmployeeRepository _employeeRepository;
        #endregion

        #region Constructors

        /// <summary>
        /// Constructor that requires a repository as a parameter.
        /// </summary>
        /// <param name="employeeRepository">Repository to be used.</param>
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Method calls on repositorty to return a list of all Employees from the database.
        /// </summary>
        /// <returns>Returns a list of all Employees in the database, in the form of Data Transfer Objects.</returns>
        public List<EmployeeDTO> GetAll()
        {
            var employeeList = Mapper.Map<List<EmployeeDTO>>(_employeeRepository.GetAll());
            return employeeList;
        }

        /// <summary>
        /// Method calls on repository to return a single Employee from the database based on SSN.
        /// </summary>
        /// <param name="ssn">Social Security Number to be looked up.</param>
        /// <returns>Employee Data Transfer Object</returns>
        public bool ValidateUser(string userName, string password)
        {
            bool authenticate = false;
            authenticate = _employeeRepository.ValidateUser(userName, password);
            return authenticate;
        }

        #endregion
    }
}
