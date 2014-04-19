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

namespace openTill.Domain.DTO
{
    /// <summary>
    /// Category Data Transfer object used to transfer the category of a product through the layers of the program.
    /// </summary>
    [ExcludeFromCodeCoverage] //Blaine Added Exclusion from coverage 4/18/2014
    public class CategoryDTO
    {
        #region Properties
        /// <summary>
        /// Category ID
        /// </summary>
        public int Id;
        /// <summary>
        /// Category Name
        /// </summary>
        public string Name;
        /// <summary>
        /// Category Description
        /// </summary>
        public string Description;
        #endregion
    }
}
