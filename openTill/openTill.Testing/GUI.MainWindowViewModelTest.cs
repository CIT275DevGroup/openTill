using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using openTill.GUI;
using Moq;
using openTill.Domain;
using openTill.Domain.Services;
using openTill.Domain.DTO;
using System.Collections.Generic;
using System.Linq;
using openTill.Domain.Interface.Service;

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
        [TestMethod]
        public void ChangeQty()
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
            testVM.SelectedItem = testVM.TransactionProducts[0];
            testVM.ChangeItemQuantity(3);
            Assert.AreEqual(4, testVM.TransactionProducts[0].Quantity);
        }
        [TestMethod]
        public void DecreaseQty()
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
            testVM.SelectedItem = testVM.TransactionProducts[0];
            testVM.ChangeItemQuantity(3);
            testVM.RemoveTransactionItem();
            Assert.AreEqual(3, testVM.TransactionProducts[0].Quantity);
        }
        [TestMethod]
        public void AddDuplicateTest()
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
            testVM.AddTransactionItem("1");
            CollectionAssert.AreEquivalent(mockProduct, testVM.TransactionProducts.Select(x => x.Item).ToList());
            Assert.AreEqual(2, testVM.TransactionProducts[0].Quantity);
        }
        [TestMethod]
        public void RemoveProductTest()
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
            testVM.SelectedItem = testVM.TransactionProducts[0];
            testVM.RemoveTransactionItem();
            Assert.IsTrue(testVM.TransactionProducts.Count == 0);
        }
    }
}
