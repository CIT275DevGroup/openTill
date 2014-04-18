/*Blaine Simcox 
 * CIT 275
 * Jeff Straw
 * Unit Testing Domian.BrandServices
 * 4/18/2014
 * */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using openTill.Domain.Services;
using openTill.Domain.Interface.Repository;
using openTill.Domain;

namespace DomainUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        

        /// <summary>
        /// Tests BrandServices.Delete For null References
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestBrandServiceDeleteForNullReference()
        {
            BrandService bs = new BrandService(null);
            bs.Delete(null);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestBrandServiceEqualsForNullReference()
        {
            BrandService bs = new BrandService(null);
            bs.GetAllBrands();
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestBrandServiceInsertrNullReference()
        {
            BrandService bs = new BrandService(null);
            bs.Insert(null);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestBrandServiceUpdateForNullReference()
        {
            BrandService bs = new BrandService(null);
            bs.Update(null);
        }

        
        
       


    }
}
