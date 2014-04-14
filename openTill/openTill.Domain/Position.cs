using System;
using System.Collections.Generic;
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
    /// A class of a Position for an employee.
    /// </summary>
    public class Position
    {
        #region Fields
        private int _id;
        private string _name;
        private string _description;
        #endregion

        #region Properties
        /// <summary>
        /// Position ID
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// Name of the position given to an employee.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// Description of an employees position.
        /// </summary>
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        #endregion 
    }
}
