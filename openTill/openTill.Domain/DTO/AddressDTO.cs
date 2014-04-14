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
    /// Address Data Transfer Object used to move an address around the layers of the program.
    /// </summary>
    public class AddressDTO
    {
        #region Properties
        /// <summary>
        /// Address ID
        /// </summary>
        public int ID;
        /// <summary>
        /// Street Address
        /// </summary>
        public string Street;
        /// <summary>
        /// City Address
        /// </summary>
        public string City;
        /// <summary>
        /// State Address
        /// </summary>
        public int StateID;
        /// <summary>
        /// Zip Address
        /// </summary>
        public int ZipID;
        #endregion
    }
}
