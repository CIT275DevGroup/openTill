using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  24 Feb 2014
//Revisions: 4/6/2014 Added Documentation | Curtis Reinhold

namespace openTill.Domain
{
    /// <summary>
    /// A class for an item being sold.
    /// </summary>
    public class SaleItem
    {
        #region Fields
        private int _id;
        private int _saleID;
        private int _productID;
        private decimal _sellingPrice;
        private int _quantity;
        #endregion

        #region Properties
        /// <summary>
        /// The ID of the item being sold.
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// The ID of the sale that is associated with the bought product.
        /// </summary>
        public int SaleID
        {
            get { return _saleID; }
            set { _saleID = value; }
        }
        /// <summary>
        /// The ID of the product being purchased.
        /// </summary>
        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }
        /// <summary>
        /// The selling price of the item being bought.
        /// </summary>
        public decimal SellingPrice
        {
            get { return _sellingPrice; }
            set { _sellingPrice = value; }
        }
        /// <summary>
        /// How many items are being bought.
        /// </summary>
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        #endregion
    }
}
