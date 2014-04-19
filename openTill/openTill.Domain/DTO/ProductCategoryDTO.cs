using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  24 Feb 2014
//Revisions: 4/6/2014 Added Documentation | Curtis Reinhold

namespace openTill.Domain.DTO
{
    /// <summary>
    /// ProductCategory data transfer object that moves the ProductCategory object around the layers of the program.
    /// </summary>
    [ExcludeFromCodeCoverage] //Blaine Added Exclusion from coverage 4/18/2014
    public class ProductCategoryDTO
    {
        #region Properties
        /// <summary>
        /// Category ID
        /// </summary>
        public int ID;
        /// <summary>
        /// Product UPC
        /// </summary>
        public string ProductUPC;
        /// <summary>
        /// Category ID
        /// </summary>
        public int CategoryID;
        #endregion
    }
}
