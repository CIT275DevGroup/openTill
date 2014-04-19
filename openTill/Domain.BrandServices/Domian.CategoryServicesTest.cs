/*Blaine Simcox
 * CIT 275
 * Jeff Straw
 * Unit Testing Sprint 4
 * Domain.CategoryServicesTest 75% Coverage
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

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullReferenceCategoryServiceInsert()
        {
            CategoryService cat = new CategoryService(null);

            CategoryDTO cd = new CategoryDTO();
            cd.Id = 111111;
            cd.Name = "Steve";
            cd.Description = "Looks like crap Bob!";

            cat.Insert(cd);

        }

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

        
    }
}
