﻿using System;
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
    /// Position data transfer object that moves the position object around the layers of the program.
    /// </summary>
    [ExcludeFromCodeCoverage] //Blaine Added Exclusion from coverage 4/18/2014
    public class PositionDTO
    {
        #region Properties
        /// <summary>
        /// Position ID
        /// </summary>
        public int ID;
        /// <summary>
        /// Name of Position
        /// </summary>
        public string Name;
        /// <summary>
        /// Description of Position
        /// </summary>
        public string Description;
        #endregion
    }
}
