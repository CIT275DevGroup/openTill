using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using openTill.GUI;
using openTill.Domain.DTO;
using Moq;
using openTill.Domain.Interface.Service;
using System.Collections.Generic;

namespace openTill.Testing
{
    [TestClass]
    public class InventoryViewModelTest
    {
        ObservableProduct testProduct;
        InventoryViewModel viewModel;
        Mock<IProductService> mockProduct;
        Mock<IBrandService> mockBrand;
        [TestInitialize]
        public void Initialize()
        {
            mockProduct = new Mock<IProductService>();
            mockProduct.Setup(x => x.GetAllProducts()).Returns(new List<ProductDTO>()
                {
                    new ProductDTO()
                    {
                        UPC = "111"
                    }
                });
            mockBrand = new Mock<IBrandService>();
            mockBrand.Setup(x => x.GetAllBrands()).Returns(new List<BrandDTO>()
            {
                new BrandDTO()
                {
                    Id = 1,
                    BrandName = "Test1"
                },
                new BrandDTO()
                {
                    Id = 2,
                    BrandName = "Test2"
                }
            });
            testProduct = new ObservableProduct(new ProductDTO
            {
                UPC = "123"
            });
            viewModel = new InventoryViewModel(mockProduct.Object, mockBrand.Object);
        }
        [TestMethod]
        public void InitializeTest()
        {
            Assert.IsNull(viewModel.SelectedProduct.UPC);
            Assert.IsTrue(viewModel.Products.Any(x => x.UPC == "111"));
        }
        [TestMethod]
        public void AddProductTest()
        {
            viewModel.SelectedProduct = testProduct;
            if (viewModel.AddCommand.CanExecute(testProduct.UPC))
                viewModel.AddCommand.Execute(null);
            CollectionAssert.Contains(viewModel.Products, viewModel.SelectedProduct);
        }
        [TestMethod]
        public void AddDuplicateTest()
        {
            viewModel.SelectedProduct = testProduct;
            if (viewModel.AddCommand.CanExecute(testProduct.UPC))
                viewModel.AddCommand.Execute(null);
            bool canAddAgain = viewModel.AddCommand.CanExecute(testProduct.UPC);
            Assert.IsFalse(canAddAgain);
        }
        [TestMethod]
        public void RemoveProductTest()
        {
            viewModel.SelectedProduct = testProduct;
            if (viewModel.AddCommand.CanExecute(testProduct.UPC))
                viewModel.AddCommand.Execute(null);
            if (viewModel.RemoveCommand.CanExecute(testProduct.UPC))
                viewModel.RemoveCommand.Execute(null);
            CollectionAssert.DoesNotContain(viewModel.Products, testProduct);
        }
    }
}
