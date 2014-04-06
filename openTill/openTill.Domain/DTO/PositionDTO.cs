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
    /// Position data transfer object that moves the position object around the layers of the program.
    /// </summary>
    public class PositionDTO
    {
        #region Properties
        public int ID;
        public string Name;
        public string Description;
        #endregion
    }
}
