using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using openTill.Persistence;

namespace openTill.Testing {
    [TestClass]
    public class ProductRepositoryTest {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullStringProductGetByBrandException() {
            ProductRepository testProductRepository = new ProductRepository();
            testProductRepository.GetByBrand(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WhitespaceStringProductGetByBrandException() {
            ProductRepository testProductRepository = new ProductRepository();
            testProductRepository.GetByBrand("   ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmptyStringProductGetByBrandException() {
            ProductRepository testProductRepository = new ProductRepository();
            testProductRepository.GetByBrand("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullStringProductGetByUPCException() {
            ProductRepository testProductRepository = new ProductRepository();
            testProductRepository.GetByUPC(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WhitespaceStringProductGetByUPCException() {
            ProductRepository testProductRepository = new ProductRepository();
            testProductRepository.GetByUPC("   ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmptyStringProductGetByUPCException() {
            ProductRepository testProductRepository = new ProductRepository();
            testProductRepository.GetByUPC("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullDTOProductInsertException() {
            ProductRepository testProductRepository = new ProductRepository();
            testProductRepository.Insert(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullDTOProductUpdateException() {
            ProductRepository testProductRepository = new ProductRepository();
            testProductRepository.Update(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullDTOProductDeleteException() {
            ProductRepository testProductRepository = new ProductRepository();
            testProductRepository.Delete(null);
        }
    }
}
