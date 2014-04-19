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
    /// A class for the Category of a product.
    /// </summary>
    [ExcludeFromCodeCoverage] //Blaine Added Exclusion from coverage 4/18/2014
    public class Category
    {
        #region Fields
        private int _id;
        private string _name;
        private string _description;
        #endregion

        #region Properties
        /// <summary>
        /// An Id of a category.
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value ;}
        }
        /// <summary>
        /// The Name of a category.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// A Description of a category.
        /// </summary>
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        #endregion
    }
}
