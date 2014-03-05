using openTill.Domain;
using openTill.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.GUI
{
    public class TransactionItem : ObservableObject
    {
        private ProductDTO _item;

        public ProductDTO Item
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
        public TransactionItem(ProductDTO item)
        {
            _item = item;
        }
    }
}
