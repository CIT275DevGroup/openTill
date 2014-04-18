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

namespace openTill.Domain.DTO
{
    /// <summary>
    /// Phone data transfer object that moved a phone object around the layers of the program.
    /// </summary>
    [ExcludeFromCodeCoverage ]  //Added By Blaine 4/18/2014
    public class PhoneDTO
    {
        #region Properties
        public int ID;
        public string PhoneNumber;
        #endregion
    }
}
