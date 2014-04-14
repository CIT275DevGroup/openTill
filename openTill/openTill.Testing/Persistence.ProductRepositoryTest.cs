using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using openTill.Persistence;

namespace openTill.Testing {
    /// <summary>
    /// TestClsas
    /// </summary>
    [TestClass]
    public class ProductRepositoryTest {
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullStringProductGetByBrandException() {
            ProductRepository testProductRepository = new ProductRepository();
            testProductRepository.GetByBrand(null);
        }
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WhitespaceStringProductGetByBrandException() {
            ProductRepository testProductRepository = new ProductRepository();
            testProductRepository.GetByBrand("   ");
        }
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmptyStringProductGetByBrandException() {
            ProductRepository testProductRepository = new ProductRepository();
            testProductRepository.GetByBrand("");
        }
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullStringProductGetByUPCException() {
            ProductRepository testProductRepository = new ProductRepository();
            testProductRepository.GetByUPC(null);
        }
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WhitespaceStringProductGetByUPCException() {
            ProductRepository testProductRepository = new ProductRepository();
            testProductRepository.GetByUPC("   ");
        }
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmptyStringProductGetByUPCException() {
            ProductRepository testProductRepository = new ProductRepository();
            testProductRepository.GetByUPC("");
        }

        //GetByUPC needs more tests to check return value
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullDTOProductInsertException() {
            ProductRepository testProductRepository = new ProductRepository();
            testProductRepository.Insert(null);
        }
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullDTOProductUpdateException() {
            ProductRepository testProductRepository = new ProductRepository();
            testProductRepository.Update(null);
        }
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullDTOProductDeleteException() {
            ProductRepository testProductRepository = new ProductRepository();
            testProductRepository.Delete(null);
        }
    }
}
