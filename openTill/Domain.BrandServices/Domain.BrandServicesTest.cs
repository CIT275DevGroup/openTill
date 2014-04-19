/*Blaine Simcox
 * CIT 275
 * Jeff Straw
 * Unit Testing Sprint 4
 * Domain.BrandServicesTest 92.68% Coverage
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
    public class BrandServicesTest
    {
        /// <summary>
        /// Tests for AutoMapperException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(AutoMapperMappingException))]
        public void BrandServiceDeleteMappingException()
        {
            Mock<IBrandRepository> mock = new Mock<IBrandRepository>();
            Brand br = new Brand();
            BrandService bs = new BrandService(mock.Object);
            bs.Delete(br);
        }

        /// <summary>
        /// Test for Null BrandService parameter with delete method
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullBrandBrandServiceDeleteMappingException()
        {
            Brand br = null;
            BrandService bs = new BrandService(null);
            bs.Delete(br);
        }

        /// <summary>
        /// Tests for AutoMapperException with null BrandService Parameter
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(AutoMapperMappingException))]
        public void NullBrandServiceDeleteMappingException()
        {
            Brand br = new Brand();
            BrandService bs = new BrandService(null);
            bs.Delete(br);
        }

        /// <summary>
        /// Test That Brand Service is Not Null
        /// </summary>
        [TestMethod]
        public void BrandServiceIsNotNull()
        {
            BrandService es = new BrandService(null);
            Assert.IsNotNull(es);
        }

        /// <summary>
        /// Test That Brand Service Is Null
        /// </summary>
        [TestMethod]
        public void BrandServiceIsNull()
        {
            BrandService es = null;
            Assert.IsNull(es);
        }

        /// <summary>
        /// Tests Equality of Two BrandService Objects with the Same Parameters
        /// </summary>
        [TestMethod]
        public void BrandServiceIsEqual()
        {
            Mock<IBrandRepository> mock = new Mock<IBrandRepository>();
            BrandService es = new BrandService(mock.Object);
            BrandService es1 = new BrandService(mock.Object);
            Assert.ReferenceEquals(es, es1);
        }

        /// <summary>
        /// Tests Inequality o Two BrandService Objects With different object parameters
        /// </summary>
        [TestMethod]
        public void BrandServiceIsNotEqual()
        {
            Mock<IBrandRepository> mock = new Mock<IBrandRepository>();
            Mock<IBrandRepository> mock1 = new Mock<IBrandRepository>();
            BrandService es = new BrandService(mock.Object);
            BrandService es1 = new BrandService(mock1.Object);
            Assert.AreNotEqual(es, es1);
        }

        /// <summary>
        /// Tests that Two BrandService Objects with Different Are Not The Same Objects
        /// </summary>
        [TestMethod]
        public void BrandServiceIsNotSame()
        {
            Mock<IBrandRepository> mock = new Mock<IBrandRepository>();
            Mock<IBrandRepository> mock1 = new Mock<IBrandRepository>();
            BrandService es = new BrandService(mock.Object);
            BrandService es1 = new BrandService(mock1.Object);
            Assert.AreNotSame(es, es1);
        }


        


    }
}
