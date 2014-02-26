using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using openTill.Domain;

namespace openTill.Testing {
    [TestClass]
    public class BrandTest {
        [TestMethod]
        public void CheckNewBrandID() {
            Brand testBrand = new Brand();
            Assert.AreEqual(0, testBrand.ID);
        }
        [TestMethod]
        public void CheckNewBrand() {
            Brand testBrand = new Brand();
            Assert.AreEqual("", testBrand.BrandName);
        }
    }
}
