using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using openTill.Persistence;

namespace openTill.Testing {
    /// <summary>
    /// TestClass
    /// </summary>
    [TestClass]
    public class BrandRepositoryTest {
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullDTOBrandInsertException() {
            BrandRepository testBrandRepository = new BrandRepository();
            testBrandRepository.Insert(null);
        }
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullDTOBrandUpdateException() {
            BrandRepository testBrandRepository = new BrandRepository();
            testBrandRepository.Update(null);
        }
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullDTOBrandDeleteException() {
            BrandRepository testBrandRepository = new BrandRepository();
            testBrandRepository.Delete(null);
        }
    }
}
