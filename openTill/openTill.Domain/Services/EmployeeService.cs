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
        /// Method calls on repositorty to insert a new Employee into the database.
        /// </summary>
        /// <param name="employeeToAdd">Employee Data Transfer Object to the inserted into the database.</param>
        public void Insert(EmployeeDTO employeeToInsert)
        {
            _employeeRepository.Insert(employeeToInsert); 
        }

        /// <summary>
        /// Method calls on repository to remove an exisiting Employee from the database.
        /// </summary>
        /// <param name="employeeToRemove">Employee Data Transfer Object to be removed from the database.</param>
        public void Remove(EmployeeDTO employeeToDelete)
        {
            _employeeRepository.Delete(employeeToDelete);
        }

        /// <summary>
        /// Method calls on repository to update an existing Employee in the database.
        /// </summary>
        /// <param name="employeeToUpdate">Employee Data Transfer Object to be updated in the database.</param>
        public void Update(EmployeeDTO employeeToUpdate)
        {
            _employeeRepository.Update(employeeToUpdate);
        }

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
        public EmployeeDTO GetBySSN(string ssn)
        {
            var employeeToReturn = _employeeRepository.GetBySSN(ssn);
            return employeeToReturn;
        }

        /// <summary>
        /// Method calls on repository to return a list of Employees based on a last name string.
        /// </summary>
        /// <param name="lastName">Last name to be used for lookup.</param>
        /// <returns>List of Employee Data Transfer Objects.</returns>
        public List<EmployeeDTO> GetByLastName(string lastName)
        {
            var employeeList = Mapper.Map<List<EmployeeDTO>>(_employeeRepository.GetByLastName(lastName));
            return employeeList;
        }

        #endregion
    }
}
