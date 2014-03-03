using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using openTill.Persistence;

namespace openTill.Testing {
    [TestClass]
    public class CategoryRepositoryTest {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullStringGetByNameException() {
            CategoryRepository testCategoryRepository = new CategoryRepository();
            testCategoryRepository.GetByName(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WhitespaceStringGetByNameException() {
            CategoryRepository testCategoryRepository = new CategoryRepository();
            testCategoryRepository.GetByName("   ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmptyStringGetByNameException() {
            CategoryRepository testCategoryRepository = new CategoryRepository();
            testCategoryRepository.GetByName("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullDTOCategoryInsertException() {
            CategoryRepository testCategoryRepository = new CategoryRepository();
            testCategoryRepository.Insert(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullDTOCategoryUpdateException() {
            CategoryRepository testCategoryRepository = new CategoryRepository();
            testCategoryRepository.Update(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullDTOCategoryDeleteException() {
            CategoryRepository testCategoryRepository = new CategoryRepository();
            testCategoryRepository.Delete(null);
        }
    }
}
