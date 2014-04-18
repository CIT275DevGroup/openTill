/*Blaine Simcox 
 * CIT 275
 * Jeff Straw
 * Unit Testing Domian.CategoryServices
 * 4/18/2014
 * */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using openTill.Domain.Services;
using openTill.Domain.Interface.Repository;
using openTill.Domain.DTO;
using Moq;

namespace DomainUnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestCategoryServiceDeleteForNullReference()
        {
            CategoryService bs = new CategoryService(null);
            bs.Delete(null);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestCategoryServiceEqualsForNullReference()
        {
            CategoryService bs = new CategoryService(null);
            bs.GetAll();
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestCategoryServiceInsertrNullReference()
        {
            CategoryService bs = new CategoryService(null);
            bs.Insert(null);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestCategoryServiceUpdateForNullReference()
        {
            CategoryService bs = new CategoryService(null);
            bs.Update(null);
        }
        
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestCategoryServiceGetByNameForNullReference()
        {
            CategoryService bs = new CategoryService(null);
            bs.GetByName(null);
        }

        [TestMethod]
        public void TestGetNameEquality()
        {
            Mock<ICategoryRepository> mock = new Mock<ICategoryRepository>();
            CategoryService cs = new CategoryService(mock.Object);
            CategoryService cs1 = new CategoryService(mock.Object);

            Assert.AreEqual(cs.GetByName("Sarah"), cs1.GetByName("Sarah"));
        }

        

        [TestMethod]
        public void TestConstructorEquality()
        {
            Mock<ICategoryRepository> mock = new Mock<ICategoryRepository>();
            CategoryService cs = new CategoryService(mock.Object);

            Assert.AreSame(cs, cs);
        }
        
        [TestMethod]
        public void TestConstructorNullEquality()
        {
            CategoryService cs = null;
            Assert.IsNull(cs);
        }

        [TestMethod]
        public void TestConstructorNotNullEquality()
        {
            Mock<ICategoryRepository> mock = new Mock<ICategoryRepository>();
            CategoryService cs = new CategoryService(mock.Object);

            Assert.IsNotNull(cs);
        }



       
        
    }
}
