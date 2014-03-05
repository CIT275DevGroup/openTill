using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using openTill.GUI;
using Moq;
using openTill.Domain;
using openTill.Domain.Services;
using openTill.Domain.DTO;
using System.Collections.Generic;
using System.Linq;

namespace openTill.Testing
{
    [TestClass]
    public class MainWindowViewModelTest
    {
        [TestMethod]
        public void InstantiateTest()
        {
            var mock = new Mock<IProductService>();
            List<ProductDTO> mockProduct = new List<ProductDTO>{
                    new ProductDTO
                    {
                        UPC = "1"
                    }};
            mock.Setup(framework => framework.GetAllProducts())
                .Returns(mockProduct);
            MainWindowViewModel testVM = new MainWindowViewModel(mock.Object);
            Assert.IsNotNull(testVM);
        }
        [TestMethod]
        public void GetProductTest()
        {
            var mock = new Mock<IProductService>();
            List<ProductDTO> mockProduct = new List<ProductDTO>{
                    new ProductDTO
                    {
                        UPC = "1"
                    }};
            mock.Setup(framework => framework.GetAllProducts())
                .Returns(mockProduct);
            mock.Setup(framework => framework.GetProductByUPC("1"))
                .Returns(mockProduct.First(x => x.UPC == "1"));
            MainWindowViewModel testVM = new MainWindowViewModel(mock.Object);
            testVM.AddTransactionItem("1");
            CollectionAssert.AreEquivalent(mockProduct, testVM.TransactionProducts.Select(x => x.Item).ToList());
        }
    }
}
