using System;
using System.Collections.Generic;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  03 Mar 2014
//Revisions:

namespace openTill.Domain.DTO
{
    public class SaleDTO
    {
        #region Properties

        public int Id;
        public decimal Total;
        public int EmployeeID;
        public DateTime DateOfSale;
        public List<SaleItemDTO> SaleItems;

        #endregion
    }
}
