using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  24 Feb 2014
//Revisions: 4/6/2014 Added Documentation | Curtis Reinhold

namespace openTill.Domain.DTO
{
    /// <summary>
    /// Product data transfer object that moves a product around the layers of the program.
    /// </summary>
    public class ProductDTO
    {
        #region Properties
        /// <summary>
        /// Product UPC
        /// </summary>
        public string UPC;
        /// <summary>
        /// Category List ID
        /// </summary>
        public int CategoryListID;
        /// <summary>
        /// Brand ID
        /// </summary>
        public int BrandID;
        /// <summary>
        /// Brand Name
        /// </summary>
        public string Name;
        /// <summary>
        /// Brand Description
        /// </summary>
        public string Description;
        /// <summary>
        /// Store Cost
        /// </summary>
        public decimal StoreCost;
        /// <summary>
        /// Selling Price
        /// </summary>
        public decimal SellingPrice;
        /// <summary>
        /// Minimum On Hand
        /// </summary>
        public int MinOnHand;
        /// <summary>
        /// Amount on Hand
        /// </summary>
        public int OnHand;
        /// <summary>
        /// Does it have a deposit?
        /// </summary>
        public bool HasDeposit;
        /// <summary>
        /// Is it taxable?
        /// </summary>
        public bool IsTaxable;
        /// <summary>
        /// Minimum Age?
        /// </summary>
        public int MinimumAge;
        /// <summary>
        /// List of Categories
        /// </summary>
        public List<CategoryDTO> CategoryList;
        #endregion
    }
}
