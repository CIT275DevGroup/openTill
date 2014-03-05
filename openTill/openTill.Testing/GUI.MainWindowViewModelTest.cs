using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using openTill.GUI;

namespace openTill.Testing
{
    [TestClass]
    public class MainWindowViewModelTest
    {
        [TestMethod]
        public void InstantiateTest()
        {
            MainWindowViewModel testVM = new MainWindowViewModel();
            Assert.IsNotNull(testVM);
        }
        [TestMethod]
        public void GetProductTest()
        {

        }
    }
}
