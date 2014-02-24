using AutoMapper;
using openTill.Domain.DTO;
using openTill.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain.Services
{
    class EmployeeService
    {
        #region Fields
        private readonly IEmployeeRepository _employeeRepository;
        #endregion

        #region Constructors
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        #endregion

        #region Methods

        public void Add(Employee employeeToAdd)
        {
            var toAdd = Mapper.Map<EmployeeDTO>(employeeToAdd);
            _employeeRepository.Add(toAdd); 
        }

        public void Remove(Employee employeeToRemove)
        {
            var toRemove = Mapper.Map<EmployeeDTO>(employeeToRemove);
            _employeeRepository.Remove(toRemove);
        }

        public void Update(Employee employeeToUpdate)
        {
            var toUpdate = Mapper.Map<EmployeeDTO>(employeeToUpdate);
            _employeeRepository.Update(toUpdate);
        }

        public List<EmployeeDTO> GetAll()
        {
            var employeeList = Mapper.Map<List<EmployeeDTO>>(_employeeRepository.GetAll());
            return employeeList;
        }

        public EmployeeDTO GetBySSN(string ssn)
        {
            var employeeToReturn = _employeeRepository.GetBySSN(ssn);
            return employeeToReturn;
        }

        public List<EmployeeDTO> GetByLastName(string lastName)
        {
            var employeeList = Mapper.Map<List<EmployeeDTO>>(_employeeRepository.GetByLastName(lastName));
            return employeeList;
        }

        #endregion
    }
}
