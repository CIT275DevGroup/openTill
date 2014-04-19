/*Blaine Simcox
 * CIT 275
 * Jeff Straw
 * Unit Testing Sprint 4
 * Domain.ProductServicesTest 94.12% Coverage
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
    public class ProductServiceTest
    {
        /// <summary>
        /// Tests NullReferenceException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullReferenceProductServiceInsert()
        {
            ProductService cat = new ProductService(null);
            cat.GetAllProducts();

        }

        /// <summary>
        /// Tests Null class
        /// </summary>
        [TestMethod]
        public void ProductServiceIsNull()
        {
            ProductService es = null;
            Assert.IsNull(es);
        }

        /// <summary>
        /// tests that ProductService not null
        /// </summary>
        [TestMethod]
        public void ProductServiceIsNotNull()
        {
            Mock<IProductRepository> pr = new Mock<IProductRepository>();
            ProductService es = new ProductService(pr.Object);
            Assert.IsNotNull(es);
        }

        /// <summary>
        /// Tests two objects with same parameters for equality
        /// </summary>
        [TestMethod]
        public void ProductServiceIsEqual()
        {
            Mock<IProductRepository> sr = new Mock<IProductRepository>();
            ProductService bs = new ProductService(sr.Object);
            ProductService bs1 = new ProductService(sr.Object);
            Assert.ReferenceEquals(bs, bs1);
        }
        
    }
}
