using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using openTill.Persistence;

namespace openTill.Testing
{
    /// <summary>
    /// TestClass
    /// </summary>
    [TestClass]
    public class SaleRepositoryTest
    {
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullStringSaleGetByEmployeeException() {
            SaleRepository testSaleRepository = new SaleRepository();
            testSaleRepository.GetSalesByEmployee(null);
        }
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WhitespaceStringSaleGetByEmployeeException() {
            SaleRepository testSaleRepository = new SaleRepository();
            testSaleRepository.GetSalesByEmployee("   ");
        }
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmptyStringSaleGetByEmployeeException() {
            SaleRepository testSaleRepository = new SaleRepository();
            testSaleRepository.GetSalesByEmployee("");
        }
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void InsertNullSale() {
            SaleRepository testSaleRepository = new SaleRepository();
            testSaleRepository.Insert(null);
        }
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void UpdateNullSale() {
            SaleRepository testSaleRepository = new SaleRepository();
            testSaleRepository.Update(null);
        }
    }
}
