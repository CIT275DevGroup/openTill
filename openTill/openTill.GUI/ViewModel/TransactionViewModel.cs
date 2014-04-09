using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Practices.ServiceLocation;
using openTill.Domain.Interface.Service;
using openTill.GUI.Models;
using openTill.Persistence;
using System.Collections.ObjectModel;
using System.Linq;

namespace openTill.GUI.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class TransactionViewModel : ViewModelBase
    {
        private IProductService productService;
        private ObservableCollection<ObservableProduct> _products;
        /// <summary>
        /// Initializes a new instance of the TransactionViewModel class.
        /// </summary>
        public TransactionViewModel()
        {
            AutomapperBootstrapper.Initialize();
            productService = ServiceLocator.Current.GetInstance<IProductService>();
            TransactionProducts = new ObservableCollection<ObservableProduct>();
        }
        /// <summary>
        /// The <see cref="Products" /> property's name.
        /// </summary>
        public const string ProductsPropertyName = "Products";
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
        private RelayCommand<ObservableProduct> _addToTransactionCommand;

        /// <summary>
        /// Gets the AddToTransactionCommand.
        /// </summary>
        public RelayCommand<ObservableProduct> AddToTransactionCommand
        {
            get
            {
                return _addToTransactionCommand
                    ?? (_addToTransactionCommand = new RelayCommand<ObservableProduct>(
                                          (param) =>
                                          {
                                              TransactionProducts.Add(param);
                                          }));
            }
        }
        /// <summary>
        /// The <see cref="TransactionProducts" /> property's name.
        /// </summary>
        public const string TransactionProductsPropertyName = "TransactionProducts";

        private ObservableCollection<ObservableProduct> _transactionProducts;

        /// <summary>
        /// Sets and gets the TransactionProducts property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ObservableCollection<ObservableProduct> TransactionProducts
        {
            get
            {
                return _transactionProducts;
            }
            set
            {
                Set(TransactionProductsPropertyName, ref _transactionProducts, value);
            }
        }
        private RelayCommand _searchProductsCommand;

        /// <summary>
        /// Gets the SearchProductsCommand.
        /// </summary>
        public RelayCommand SearchProductsCommand
        {
            get
            {
                return _searchProductsCommand
                    ?? (_searchProductsCommand = new RelayCommand(
                                          () =>
                                          {
                                              Products = new ObservableCollection<ObservableProduct>(productService.GetAllProducts().Where(x => (FilterString.ToLower().Contains(x.UPC) || FilterString.ToLower().Contains(x.Name.ToLower()))).Select(x => new ObservableProduct(x)));
                                          }));
            }
        }
        /// <summary>
        /// The <see cref="FilterString" /> property's name.
        /// </summary>
        public const string FilterStringPropertyName = "FilterString";

        private string _filterString;

        /// <summary>
        /// Sets and gets the FilterString property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string FilterString
        {
            get
            {
                return _filterString;
            }
            set
            {
                Set(FilterStringPropertyName, ref _filterString, value);
            }
        }
    }
}