using GalaSoft.MvvmLight;
using openTill.Domain.DTO;
using openTill.GUI.Models;

namespace openTill.GUI
{
    /// <summary>
    /// Wrapper model for ProductDTO, adds Quantity property
    /// </summary>
    public class TransactionItem : ObservableObject
    {
        /// <summary>
        /// The <see cref="Item" /> property's name.
        /// </summary>
        public const string ItemPropertyName = "Item";

        private ObservableProduct _item;

        /// <summary>
        /// Sets and gets the Item property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public ObservableProduct Item
        {
            get
            {
                return _item;
            }
            set
            {
                Set(ItemPropertyName, ref _item, value);
            }
        }
        /// <summary>
        /// The <see cref="Quantity" /> property's name.
        /// </summary>
        public const string QuantityPropertyName = "Quantity";

        private int _quantity;

        /// <summary>
        /// Sets and gets the Quantity property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                Set(QuantityPropertyName, ref _quantity, value);
            }
        }

        /// <summary>
        /// Default constructor, sets the ProductDTO represented by this TransactionItem
        /// </summary>
        /// <param name="item">the ProductDTO this object will represent</param>
        public TransactionItem(ProductDTO item)
        {
            Item = new ObservableProduct(item);
        }
    }
}