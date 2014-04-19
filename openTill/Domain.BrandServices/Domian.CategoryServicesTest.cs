/*Blaine Simcox
 * CIT 275
 * Jeff Straw
 * Unit Testing Sprint 4
 * Domain.CategoryServicesTest 92.86% Coverage
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
    public class CategoryServicesTest
    {
        /// <summary>
        /// Tests NullRefernceException Using Delete Method
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullReferenceCategoryServiceDelete()
        {
            CategoryService cat = new CategoryService(null);

            CategoryDTO cd = new CategoryDTO();
            cd.Id = 111111;
            cd.Name = "Steve";
            cd.Description = "Looks like crap Bob!";

            cat.Delete(cd);
            
        }

        /// <summary>
        /// Tests NullRefernceException Using Update Method
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullReferenceCategoryServiceUpdate()
        {
            CategoryService cat = new CategoryService(null);

            CategoryDTO cd = new CategoryDTO();
            cd.Id = 111111;
            cd.Name = "Steve";
            cd.Description = "Looks like crap Bob!";

            cat.Update(cd);

        }

        /// <summary>
        /// Tests That CategoryServices Is Not Null
        /// </summary>
        [TestMethod]
        public void CategoryServiceIsNotNull()
        {
            CategoryService es = new CategoryService(null);
            Assert.IsNotNull(es);
        }

        /// <summary>
        /// Tests For Null CategoryService
        /// </summary>
        [TestMethod]
        public void CategoryServiceIsNull()
        {
            CategoryService es = null;
            Assert.IsNull(es);
        }

        /// <summary>
        /// Tests Two CategoryServices With The Same Parameters For Equality
        /// </summary>
        [TestMethod]
        public void CategoryServiceIsEqual()
        {
            Mock<ICategoryRepository> mock = new Mock<ICategoryRepository>();
            CategoryService es = new CategoryService(mock.Object);
            CategoryService es1 = new CategoryService(mock.Object);
            Assert.ReferenceEquals(es, es1);
        }

        /// <summary>
        /// Tests Two CategoryServices With The Same Parameters For Inequality
        /// </summary>
        [TestMethod]
        public void CategoryServiceIsNotEqual()
        {
            Mock<ICategoryRepository> mock = new Mock<ICategoryRepository>();
            Mock<ICategoryRepository> mock1 = new Mock<ICategoryRepository>();
            CategoryService es = new CategoryService(mock.Object);
            CategoryService es1 = new CategoryService(mock1.Object);
            Assert.AreNotEqual(es, es1);
        }

        
    }
}
