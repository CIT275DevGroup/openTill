using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  24 Feb 2014
//Revisions:

namespace openTill.Domain
{
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
        public string UPC
        {
            get { return _upc; }
            set { _upc = value; }
        }
        
        public int CategoryListID
        {
            get { return _categoryListID; }
            set { _categoryListID = value; }
        }
        
        public int BrandID
        {
            get { return _brandID; }
            set { _brandID = value; }
        }
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        
        public decimal StoreCost
        {
            get { return _storeCost; }
            set { _storeCost = value; }
        }
        
        public decimal SellingPrice
        {
            get { return _sellingPrice; }
            set { _sellingPrice = value; }
        }
        
        public int OnHand
        {
            get { return _onHand; }
            set { _onHand = value; }
        }
        
        public int MinOnHand
        {
            get { return _minOnHand; }
            set { _minOnHand = value; }
        }
        
        public bool HasDeposit
        {
            get { return _hasDeposit; }
            set { _hasDeposit = value; }
        }
        
        public bool IsTaxable
        {
            get { return _isTaxable; }
            set { _isTaxable = value; }
        }
        
        public int MinimumAge
        {
            get { return _minimumAge; }
            set { _minimumAge = value; }
        }
        public List<ProductCategory> CategoryList
        {
            get { return _categoryList; }
            set { _categoryList = value; }
        }

        #endregion
    }
}
