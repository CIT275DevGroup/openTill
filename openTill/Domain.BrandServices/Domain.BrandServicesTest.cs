/*Blaine Simcox
 * CIT 275
 * Jeff Straw
 * Unit Testing Sprint 4
 * Domain.BrandServicesTest 80% Coverage
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
        [TestMethod]
        [ExpectedException(typeof(AutoMapperMappingException))]
        public void NullBrand_BrandServiceDeleteMappingException()
        {
            Mock<IBrandRepository> mock = new Mock<IBrandRepository>();
            Brand br = new Brand();
            BrandService bs = new BrandService(mock.Object);
            bs.Delete(br);
        }

        [TestMethod]
        [ExpectedException(typeof(AutoMapperMappingException))]
        public void NullBrandServiceDeleteMappingException()
        {
            Brand br = new Brand();
            BrandService bs = new BrandService(null);
            bs.Delete(br);
        }


        


    }
}
