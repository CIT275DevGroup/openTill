using openTill.Domain;
using openTill.Domain.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.GUI
{
    class MainWindowViewModel : ObservableObject
    {
        public MainWindowViewModel()
        {
            throw new NotImplementedException();
        }
        public MainWindowViewModel(ProductService productService)
        {
            _productService = productService;
        }
        private ProductService _productService;
        private ObservableCollection<TransactionItem> _transactionProducts;

        public ObservableCollection<TransactionItem> TransactionProducts
        {
            get { return _transactionProducts; }
            set
            {
                _transactionProducts = value;
            }
        }
        private TransactionItem _selectedItem;

        public TransactionItem SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                RaisePropertyChanged("SelectedItem");
            }
        }

        public void AddTransactionItem(string UPC)
        {
            if (TransactionProducts.Any(x => x.Item.UPC == UPC))
            {
                TransactionItem matchingItem = TransactionProducts.First(x => x.Item.UPC == UPC);
                SelectedItem = matchingItem;
                matchingItem.Quantity += 1;
            }
            else
            {
                TransactionItem newItem = new TransactionItem(_productService.GetProductByUPC(UPC));
                if (newItem != null)
                    TransactionProducts.Add(newItem);
                else
                    throw new ArgumentException("UPC: " + UPC + "Not found in the system");
            }
        }
        public void RemoveTransactionItem()
        {
            TransactionProducts.Remove(SelectedItem);
        }
        public void ChangeItemQuantity(int amount)
        {
            SelectedItem.Quantity += amount;
        }

    }
}
