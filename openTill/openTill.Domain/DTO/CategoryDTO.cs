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
    /// Category Data Transfer object used to transfer the category of a product through the layers of the program.
    /// </summary>
    [ExcludeFromCodeCoverage ]  //Code Coverage Exclusion Added By Blaine 4/18/2014
    public class CategoryDTO
    {
        #region Properties
        public int Id;
        public string Name;
        public string Description;
        #endregion
    }
}
