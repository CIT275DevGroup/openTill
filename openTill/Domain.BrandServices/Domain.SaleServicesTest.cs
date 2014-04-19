/*Blaine Simcox
 * CIT 275
 * Jeff Straw
 * Unit Testing Sprint 4
 * Domain.BrandServicesTest 94.74% Coverage
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
    public class SaleServicesTest
    {
        /// <summary>
        /// Tests NullReferenceException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SaleServiceGetAllNullReferenceExceptionTest()
        {
            Mock<ISaleRepository> sr = new Mock<ISaleRepository>();
            SaleService bs = new SaleService(sr.Object);
            bs.FinalizeSale(null);
        }

        /// <summary>
        /// Tests Null SaleService Object
        /// </summary>
        [TestMethod]
        public void SaleServiceIsNull()
        {
            SaleService es = null;
            Assert.IsNull(es);
        }

        /// <summary>
        /// Tests That Sale Service Is Not Null
        /// </summary>
        [TestMethod]
        public void SaleServiceIsNotNull()
        {
            Mock<ISaleRepository> mock = new Mock<ISaleRepository>();
            SaleService es = new SaleService(mock.Object);
            Assert.IsNotNull(es);
        }

        /// <summary>
        /// Tests Two SaleService Objects For Equality
        /// </summary>
        [TestMethod]
        public void SaleServiceIsEqual()
        {
            Mock<ISaleRepository> sr = new Mock<ISaleRepository>();
            SaleService bs = new SaleService(sr.Object);
            SaleService bs1 = new SaleService(sr.Object);
            Assert.ReferenceEquals(bs, bs1);
        }
    }
}
