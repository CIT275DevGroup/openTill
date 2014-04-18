using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
    /// A class for a product.
    /// </summary>
    [ExcludeFromCodeCoverage]//added by Blaine 4/18/2014
    public class Product
    {
        #region Fields
        private string _upc;
        private int _categoryListID;
        private int _brandID;
        private string _name;
        private string _description;
        private decimal _storeCost;
        private decimal _sellingPrice;
        private int _minOnHand;
        private int _onHand;
        private bool _hasDeposit;
        private bool _isTaxable;
        private int _minimumAge;
        private List<ProductCategory> _categoryList; 
        #endregion

        #region Properties
        /// <summary>
        /// The UPC of the product.
        /// </summary>
        public string UPC
        {
            get { return _upc; }
            set { _upc = value; }
        }
        /// <summary>
        /// The ID of the category of the product.
        /// </summary>
        public int CategoryListID
        {
            get { return _categoryListID; }
            set { _categoryListID = value; }
        }
        /// <summary>
        /// The ID of the brand associated with the product.
        /// </summary>
        public int BrandID
        {
            get { return _brandID; }
            set { _brandID = value; }
        }
        /// <summary>
        /// The name of the product.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// The description of the product.
        /// </summary>
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        /// <summary>
        /// How much it Cost the Store to buy the product.
        /// </summary>
        public decimal StoreCost
        {
            get { return _storeCost; }
            set { _storeCost = value; }
        }
        /// <summary>
        /// The Selling Price of a product.
        /// </summary>
        public decimal SellingPrice
        {
            get { return _sellingPrice; }
            set { _sellingPrice = value; }
        }
        /// <summary>
        /// The current amount of a product in stock.
        /// </summary>
        public int OnHand
        {
            get { return _onHand; }
            set { _onHand = value; }
        }
        /// <summary>
        /// Minimum amount allowed on hand before ordering more of a product.
        /// </summary>
        public int MinOnHand
        {
            get { return _minOnHand; }
            set { _minOnHand = value; }
        }
        /// <summary>
        /// Does the product have a deposit?
        /// </summary>
        public bool HasDeposit
        {
            get { return _hasDeposit; }
            set { _hasDeposit = value; }
        }
        /// <summary>
        /// Is the product taxable?
        /// </summary>
        public bool IsTaxable
        {
            get { return _isTaxable; }
            set { _isTaxable = value; }
        }
        /// <summary>
        /// The minimum age that is required to be able to buy certain products.
        /// </summary>
        public int MinimumAge
        {
            get { return _minimumAge; }
            set { _minimumAge = value; }
        }
        /// <summary>
        /// A list for the possible categories for a product. Uses the ProductCategory class.
        /// </summary>
        public List<ProductCategory> CategoryList
        {
            get { return _categoryList; }
            set { _categoryList = value; }
        }
        #endregion
    }
}
