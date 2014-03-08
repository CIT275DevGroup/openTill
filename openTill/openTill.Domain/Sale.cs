using openTill.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  03 Mar 2014
//Revisions:

namespace openTill.Domain
{
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

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public DateTime DateOfSale
        {
            get { return _dateOfSale; }
            set { _dateOfSale = value; }
        }
      
        public decimal Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public int EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }

        public List<SaleItemDTO> SaleItems
        {
            get { return _saleItems; }
            set { _saleItems = value; }
        }

        #endregion




    }
}
