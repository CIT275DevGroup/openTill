using openTill.Domain.Interface.Service;
using openTill.Domain.Services;
using openTill.GUI.Commands;
using openTill.Persistence;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace openTill.GUI
{
    /// <summary>
    /// Contains state and commands for the Main Window
    /// </summary>
    public class MainWindowViewModel : ObservableObject
    {
        private ChangeQtyCommand qtyCommand;

        public ChangeQtyCommand QtyCommand
        {
            get { return qtyCommand; }
            private set { qtyCommand = value; }
        }

        /// <summary>
        /// Default constructor, instantiates a ProductService
        /// </summary>
        public MainWindowViewModel()
        {
            this.productService = new ProductService(new ProductRepository());
            QtyCommand = new ChangeQtyCommand(this);
        }

        /// <summary>
        /// Constructor taking an IProductService for testing
        /// </summary>
        /// <param name="productService"></param>
        public MainWindowViewModel(IProductService productService)
        {
            this.productService = productService;
        }

        private IProductService productService;
        private ObservableCollection<TransactionItem> _transactionProducts = new ObservableCollection<TransactionItem>();

        /// <summary>
        /// ObservableCollection of ProductDTO wrapped with quantity
        /// </summary>
        public ObservableCollection<TransactionItem> TransactionProducts
        {
            get { return _transactionProducts; }
            set
            {
                _transactionProducts = value;
            }
        }

        private TransactionItem _selectedItem;

        /// <summary>
        /// Represents currently selected item from TransactionProducts
        /// </summary>
        public TransactionItem SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                RaisePropertyChanged("SelectedItem");
            }
        }

        /// <summary>
        /// Uses IProductService to try and pull the product with the associated UPC, adds the product to Transaction Items if successful
        /// </summary>
        /// <param name="UPC">The UPC code of the product to add</param>
        public void AddTransactionItem(string UPC)
        {
            if (TransactionProducts.Any(x => x.Item.UPC == UPC))
            {
                SelectedItem = TransactionProducts.First(x => x.Item.UPC == UPC);
                SelectedItem.Quantity += 1;
            }
            else
            {
                TransactionItem newItem = new TransactionItem(productService.GetProductByUPC(UPC));
                if (newItem != null)
                    TransactionProducts.Add(newItem);
                else
                    throw new ArgumentException("UPC: " + UPC + "Not found in the system");
            }
        }

        /// <summary>
        /// Will remove the SelectedItem from TransactionItems, if not null
        /// </summary>
        public void RemoveTransactionItem()
        {
            if (SelectedItem != null)
            {
                if (SelectedItem.Quantity > 1)
                    SelectedItem.Quantity -= 1;
                else
                {
                    TransactionProducts.Remove(SelectedItem);
                }
            }
        }

        /// <summary>
        /// Changes the quantity property of the SelectedItem
        /// </summary>
        /// <param name="amount">amount by which to modify the quantity of the SelectedItem</param>
        public void ChangeItemQuantity(int amount)
        {
            SelectedItem.Quantity += amount;
        }
    }
}