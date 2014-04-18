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
    /// A class that associates a products UPC with the ID of a Category.
    /// </summary>
    [ExcludeFromCodeCoverage]//added by Blaine 4/18/2014
    public class ProductCategory
    {
        #region Fields
        private int _id;
        private string _productUPC;
        private int _categoryID;
        #endregion

        #region Properties
        /// <summary>
        /// The ID for the ProductCategory
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// The UPC of the product
        /// </summary>
        public string ProductUPC
        {
            get { return _productUPC; }
            set { _productUPC = value; }
        }
        /// <summary>
        /// The ID of the Category.
        /// </summary>
        public int CategoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }
        #endregion
    }
}
