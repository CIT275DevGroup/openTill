using openTill.Domain;
using openTill.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.GUI
{
    /// <summary>
    /// Wrapper model for ProductDTO, adds Quantity property
    /// </summary>
    public class TransactionItem : ObservableObject
    {
        private ProductDTO _item;
        /// <summary>
        /// The ProductDTO associated with this TransactionItem
        /// </summary>
        public ProductDTO Item
        {
            get { return _item; }
            set 
            { 
                _item = value;
                RaisePropertyChanged("Item");
            }
        }
        private int _quantity = 1;
       /// <summary>
       /// The quantity of the ProductDTO represented by this object
       /// </summary>
        public int Quantity
        {
            get { return _quantity; }
            set 
            { 
                _quantity = value;
                RaisePropertyChanged("Quantity");
            }
        }
        /// <summary>
        /// Default constructor, sets the ProductDTO represented by this TransactionItem
        /// </summary>
        /// <param name="item">the ProductDTO this object will represent</param>
        public TransactionItem(ProductDTO item)
        {
            _item = item;
        }
    }
}
