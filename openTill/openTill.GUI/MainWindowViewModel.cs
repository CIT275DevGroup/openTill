using openTill.Domain.Interface;
using openTill.Domain.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using openTill.Persistence;
using openTill.Domain.Interface.Service;

namespace openTill.GUI
{
    public class MainWindowViewModel : ObservableObject
    {
        public MainWindowViewModel()
        {
            this.productService = new ProductService(new ProductRepository());
        }
        public MainWindowViewModel(IProductService productService)
        {
            this.productService = productService;
        }
        private IProductService productService;
        private ObservableCollection<TransactionItem> _transactionProducts = new ObservableCollection<TransactionItem>();

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
        public void ChangeItemQuantity(int amount)
        {
            SelectedItem.Quantity += amount;
        }
    }
}
