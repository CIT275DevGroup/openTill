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
    /// A class for the address of an employee.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Address
    {
        #region Fields
        private int _id;
        private string _street;
        private string _city;
        private int _stateID;
        private int _zipID;
        #endregion

        #region Properties
        /// <summary>
        /// Address ID
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// The Street Address an employee lives at.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        /// <summary>
        /// The City an employee lives in.
        /// </summary>
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        /// <summary>
        /// The State an employee lives in.
        /// </summary>
        public int StateID
        {
            get { return _stateID; }
            set { _stateID = value; }
        }
        /// <summary>
        /// The Zip an employee lives in.
        /// </summary>
        public int ZipID
        {
            get { return _zipID; }
            set { _zipID = value; }
        }
        #endregion
    }
}
