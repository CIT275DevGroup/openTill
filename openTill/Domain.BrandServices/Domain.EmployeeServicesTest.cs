/*Blaine Simcox
 * CIT 275
 * Jeff Straw
 * Unit Testing Sprint 4
 * Domain.EmployeeServicesTest 92.31% Coverage
 * 4/18/2014
 * */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using openTill.Domain;
using openTill.Domain.DTO;
using openTill.Domain.Services;
using openTill.Domain.Interface;
using openTill.Domain.Interface.Repository;
using AutoMapper;

namespace Domain.BrandServices
{
    [TestClass]
    public class EmployeeServicesTest
    {
        /// <summary>
        /// Catches Null Reference Exception
        /// </summary>
        [TestMethod]   
        [ExpectedException(typeof(NullReferenceException))]
        public void EmployeeServiceGetAllNullReferenceExceptionTest()
        {
            EmployeeService bs = new EmployeeService(null);
            bs.GetAll();
            
        }

        /// <summary>
        /// Validates that EmployeeService Not Null
        /// </summary>
        [TestMethod]
        public void EmployeeServiceValidateUserTestNoNull()
        {
            EmployeeService es = new EmployeeService(null);
            Assert.IsNotNull(es);
        }

        /// <summary>
        /// Assert two objects with same data are the same
        /// </summary>
        [TestMethod]
        public void EmployeeServiceIsEqual()
        {
            Mock<IEmployeeRepository> sr = new Mock<IEmployeeRepository>();
            EmployeeService bs = new EmployeeService(sr.Object);
            EmployeeService bs1 = new EmployeeService(sr.Object);
            Assert.ReferenceEquals(bs, bs1);
        }
        
    }
}
