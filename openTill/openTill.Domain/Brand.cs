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
    /// A class for the Brand of a product.
    /// </summary>
    [ExcludeFromCodeCoverage]//Added By Blaine 4/18/2014
    public class Brand
    {
        #region Fields
        private int _id;
        private string _brandName;
        
        #endregion

        #region Properties
        /// <summary>
        /// Id of the brand.
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// BrandName of the product.
        /// </summary>
        public string BrandName
        {
            get { return _brandName; }
            set { _brandName = value; }
        }        
        #endregion
    }
}
