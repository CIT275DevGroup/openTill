﻿using System;
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
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public int SaleID
        {
            get { return _saleID; }
            set { _saleID = value; }
        }

        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }

        public decimal SellingPrice
        {
            get { return _sellingPrice; }
            set { _sellingPrice = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        #endregion
    }
}
