using openTill.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  03 Mar 2014
//Revisions:

namespace openTill.Domain
{
    /// <summary>
    /// A class for a Sale.
    /// </summary>
    [ExcludeFromCodeCoverage]//added by Blaine 4/18/2014
    class Sale
    {
        #region Fields

        private int _id;
        private decimal _total;
        private int _employeeID;
        private DateTime _dateOfSale;
        private List<SaleItemDTO> _saleItems;

        #endregion

        #region Properties
        /// <summary>
        /// The ID of the sale that took place.
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// The date of the sale.
        /// </summary>
        public DateTime DateOfSale
        {
            get { return _dateOfSale; }
            set { _dateOfSale = value; }
        }
        /// <summary>
        /// The total of the sale.
        /// </summary>
        public decimal Total
        {
            get { return _total; }
            set { _total = value; }
        }
        /// <summary>
        /// The ID of the mployee that is selling the items.
        /// </summary>
        public int EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }
        /// <summary>
        /// A list that contains the Sale Items. Uses the SaleItemDTO class.
        /// </summary>
        public List<SaleItemDTO> SaleItems
        {
            get { return _saleItems; }
            set { _saleItems = value; }
        }
        #endregion
    }
}
