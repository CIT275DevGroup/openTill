using System;
using System.Collections.Generic;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  03 Mar 2014
//Revisions: 4/6/2014 Added Documentation | Curtis Reinhold

namespace openTill.Domain.DTO
{
    /// <summary>
    /// Sale data transfer object that moves a sale object around the layers of the program.
    /// </summary>
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
