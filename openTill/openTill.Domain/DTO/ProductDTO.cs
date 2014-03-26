using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  24 Feb 2014
//Revisions:

namespace openTill.Domain.DTO
{
    public class ProductDTO
    {
        #region Properties
        public string UPC;
        public int CategoryListID;
        public int BrandID;
        public string Name;
        public string Description;
        public decimal StoreCost;
        public decimal SellingPrice;
        public int MinOnHand;
        public int OnHand;
        public bool HasDeposit;
        public bool IsTaxable;
        public int MinimumAge;
        public List<CategoryDTO> CategoryList;
        #endregion
    }
}
