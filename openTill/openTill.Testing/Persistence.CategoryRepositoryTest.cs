using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using openTill.Persistence;

namespace openTill.Testing {
    /// <summary>
    /// TestClass
    /// </summary>
    [TestClass]
    public class CategoryRepositoryTest {
        /// <summary>
        /// Test Method
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullStringCategoryGetByNameException() {
            CategoryRepository testCategoryRepository = new CategoryRepository();
            testCategoryRepository.GetByName(null);
        }
        /// <summary>
        /// Test Method
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WhitespaceStringCategoryGetByNameException()
        {
            CategoryRepository testCategoryRepository = new CategoryRepository();
            testCategoryRepository.GetByName("   ");
        }
        /// <summary>
        /// Test Method
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmptyStringCategoryGetByNameException()
        {
            CategoryRepository testCategoryRepository = new CategoryRepository();
            testCategoryRepository.GetByName("");
        }
        /// <summary>
        /// Test Method
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullDTOCategoryInsertException() {
            CategoryRepository testCategoryRepository = new CategoryRepository();
            testCategoryRepository.Insert(null);
        }
        /// <summary>
        /// Test Method
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullDTOCategoryUpdateException() {
            CategoryRepository testCategoryRepository = new CategoryRepository();
            testCategoryRepository.Update(null);
        }
        /// <summary>
        /// Test Method
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullDTOCategoryDeleteException() {
            CategoryRepository testCategoryRepository = new CategoryRepository();
            testCategoryRepository.Delete(null);
        }
    }
}
