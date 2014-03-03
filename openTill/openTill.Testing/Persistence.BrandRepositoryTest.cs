using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using openTill.Persistence;

namespace openTill.Testing {
    [TestClass]
    public class BrandRepositoryTest {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullDTOInsertException() {
            BrandRepository testBrandRepository = new BrandRepository();
            testBrandRepository.Insert(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullDTOUpdateException() {
            BrandRepository testBrandRepository = new BrandRepository();
            testBrandRepository.Update(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullDTODeleteException() {
            BrandRepository testBrandRepository = new BrandRepository();
            testBrandRepository.Delete(null);
        }
    }
}
