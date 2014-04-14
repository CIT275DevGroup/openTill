using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace openTill.Testing {
    /// <summary>
    /// Class Testing
    /// </summary>
    [TestClass]
    public class ClassBeingTestedTest {
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        public void BeDescriptiveAsIn_CheckingThatTrueEqualsTrue_BeingLongHereDoesNotMatter() {
            Assert.AreEqual(true, true);
        }
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void HowToDoTestsThatShouldFail_InThisCaseIndexOutOfBounds() {
            int[] testIntArray = new int[2];
            int testInt = testIntArray[2];
        }
        /// <summary>
        /// TestMethod
        /// </summary>
        [TestMethod]
        public void CheckTwoArraysAreEqual() {
            int[] firstTestArray = new int[2] { 0, 0 };
            int[] secondTestArray = new int[2] { 0, 0 };
            CollectionAssert.AreEqual(firstTestArray, secondTestArray);
        }
    }
}
