using openTill.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.GUI
{
    class TransactionItem : ObservableObject
    {
        private Product _item;

        public Product Item
        {
            get { return _item; }
            set 
            { 
                _item = value;
                RaisePropertyChanged("Item");
            }
        }
        private int _quantity;
       
        public int Quantity
        {
            get { return _quantity; }
            set 
            { 
                _quantity = value;
                RaisePropertyChanged("Quantity");
            }
        }
        public TransactionItem(Product item)
        {
            _item = item;
        }
    }
}
