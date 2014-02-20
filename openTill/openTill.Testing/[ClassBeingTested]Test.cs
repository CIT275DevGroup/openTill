using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace openTill.Testing {
    [TestClass]
    public class ClassBeingTestedTest {
        [TestMethod]
        public void BeDescriptiveAsIn_checkingThatTrueEqualsTrue_BeingLongHereDoesNotMatter() {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void HowToDoTestsThatShouldFail_InThisCaseIndexOutOfBounds() {
            int[] testIntArray = new int[2];
            int testInt = testIntArray[2];
        }

        [TestMethod]
        public void CheckTwoArraysAreEqual() {
            int[] firstTestArray = new int[2] { 0, 0 };
            int[] secondTestArray = new int[2] { 0, 0 };
            CollectionAssert.AreEqual(firstTestArray, secondTestArray);
        }
    }
}
