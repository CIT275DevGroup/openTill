using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Practices.ServiceLocation;
using openTill.Domain.Interface.Service;
using openTill.GUI.Models;
using openTill.Persistence;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace openTill.GUI.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class InventoryViewModel : ViewModelBase
    {
        /// <summary>
        /// The <see cref="Brands" /> property's name.
        /// </summary>
        public const string BrandsPropertyName = "Brands";

        /// <summary>
        /// The <see cref="Categories" /> property's name.
        /// </summary>
        public const string CategoriesPropertyName = "Categories";

        /// <summary>
        /// The <see cref="Products" /> property's name.
        /// </summary>
        public const string ProductsPropertyName = "Products";

        /// <summary>
        /// The <see cref="SaveButtonText" /> property's name.
        /// </summary>
        public const string SaveButtonTextPropertyName = "SaveButtonText";

        /// <summary>
        /// The <see cref="SelectedProduct" /> property's name.
        /// </summary>
        public const string SelectedProductPropertyName = "SelectedProduct";

        private RelayCommand _addCommand;
        private ObservableCollection<ObservableBrand> _brands;
        private ObservableCollection<ObservableCategory> _categories;
        private ObservableCollection<ObservableProduct> _products;
        private string _saveButtonText;
        private ObservableProduct _selectedProduct = new ObservableProduct();
        private IBrandService brandService;
        private ICategoryService categoryService;
        private IProductService productService;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public InventoryViewModel()
        {
            AutomapperBootstrapper.Initialize();
            productService = ServiceLocator.Current.GetInstance<IProductService>();
            brandService = ServiceLocator.Current.GetInstance<IBrandService>();
            categoryService = ServiceLocator.Current.GetInstance<ICategoryService>();
            RefreshProducts();
            Brands = new ObservableCollection<ObservableBrand>(brandService.GetAllBrands().Select(x => new ObservableBrand(x)));
            Categories = new ObservableCollection<ObservableCategory>(categoryService.GetAll().Select(x => new ObservableCategory(x)));
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
            else
            {
            }
        }
        private RelayCommand<ObservableProduct> _selectCommand;

        /// <summary>
        /// Gets the SelectCommand.
        /// </summary>
        public RelayCommand<ObservableProduct> SelectCommand
        {
            get
            {
                return _selectCommand
                    ?? (_selectCommand = new RelayCommand<ObservableProduct>(
                                          (param) =>
                                          {
                                              SelectedProduct = new ObservableProduct(param.GetDTO());
                                              SelectedProduct.ProductState = ObservableProduct.State.Modified;
                                          }));
            }
        }
        private RelayCommand _updateCommand;

        /// <summary>
        /// Gets the UpdateCommand.
        /// </summary>
        public RelayCommand UpdateCommand
        {
            get
            {
                return _updateCommand
                    ?? (_updateCommand = new RelayCommand(
                                          () =>
                                          {
                                              productService.RemoveProduct(productService.GetProductByUPC(SelectedProduct.UPC));
                                              productService.SaveProduct(SelectedProduct.GetDTO());
                                              SelectedProduct = new ObservableProduct();
                                          },
                                          () =>
                                          {
                                              return (Products.Any(x => x.UPC == SelectedProduct.UPC)) ? true : false;
                                          }
                                          ));
            }
        }
        private RelayCommand<ObservableProduct> _removeCommand;

        /// <summary>
        /// Gets the UpdateCommand.
        /// </summary>
        public RelayCommand<ObservableProduct> RemoveCommand
        {
            get
            {
                return _removeCommand
                    ?? (_removeCommand = new RelayCommand<ObservableProduct>(
                                          (param) =>
                                          {
                                              productService.RemoveProduct(productService.GetProductByUPC(param.UPC));
                                              SelectedProduct = new ObservableProduct();
                                              RefreshProducts();
                                          },
                                          (param) =>
                                          {
                                              return (Products.Any(x => x.UPC == param.UPC)) ? true : false;
                                          }
                                          ));
            }
        }
        /// <summary>
        /// Gets the AddCommand.
        /// </summary>
        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand
                    ?? (_addCommand = new RelayCommand(
                                          () =>
                                          {
                                              productService.SaveProduct(SelectedProduct.GetDTO());
                                              SelectedProduct = new ObservableProduct();
                                              RefreshProducts();
                                          },
                                          () =>
                                          {
                                              return (!Products.Any(x => x.UPC == SelectedProduct.UPC)) ? true : false;
                                          }));
            }
        }

        /// <summary>
        /// Sets and gets the Brands property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// </summary>
        public ObservableCollection<ObservableBrand> Brands
        {
            get { return _brands; }
            set
            {
                Set(BrandsPropertyName, ref _brands, value);
            }
        }

        /// <summary>
        /// Sets and gets the Categories property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// </summary>
        public ObservableCollection<ObservableCategory> Categories
        {
            get
            {
                return _categories;
            }
            set
            {
                Set(CategoriesPropertyName, ref _categories, value);
            }
        }

        /// <summary>
        /// Sets and gets the SelectedProduct property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// </summary>
        public ObservableCollection<ObservableProduct> Products
        {
            get
            {
                return _products;
            }
            set
            {
                Set(ProductsPropertyName, ref _products, value);
            }
        }

        /// <summary>
        /// Sets and gets the SelectedProduct property.
        /// Changes to that property's value raise the PropertyChanged event.
        /// </summary>
        public ObservableProduct SelectedProduct
        {
            get
            {
                return _selectedProduct;
            }
            set
            {
                Set(SelectedProductPropertyName, ref _selectedProduct, value);
            }
        }

        // Quick and dirty method for refreshing the products list, some sort of event or timer would probably work better
        private void RefreshProducts()
        {
            Products = new ObservableCollection<ObservableProduct>(productService.GetAllProducts().Select(x => new ObservableProduct(x)));
        }
    }
}