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

namespace openTill.Domain
{
    /// <summary>
    /// A class of a phone number for an employee.
    /// </summary>
    [ExcludeFromCodeCoverage] //Blaine Added Exclusion from coverage 4/18/2014
    public class Phone
    {
        #region Fields
        private int _id;
        private string _phoneNumber;
        #endregion

        #region Properties
        /// <summary>
        /// An ID for the PhoneNumber
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// Employees Phone Number
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        #endregion
    }
}
