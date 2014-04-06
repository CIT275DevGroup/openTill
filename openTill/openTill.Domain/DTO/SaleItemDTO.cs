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
    /// SaleItem data transfer object that moves the SaleItem object around the layers of the program.
    /// </summary>
    public class SaleItemDTO
    {
        #region Properties
        public int ID;
        public int SaleID;
        public int ProductID;
        public decimal SellingPrice;
        public int Quantity;
        #endregion
    }
}
