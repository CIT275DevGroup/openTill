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
    /// Employee data transfer object used to move an employee around the layers of the program.
    /// </summary>
    public class EmployeeDTO
    {
        #region Properties
        /// <summary>
        /// Employee ID
        /// </summary>
        public int ID;
        /// <summary>
        /// Employee First Name
        /// </summary>
        public string FName;
        /// <summary>
        /// Employee Last Name
        /// </summary>
        public string LName;
        /// <summary>
        /// Employee Position
        /// </summary>
        public int PositionID;
        /// <summary>
        /// Employee Address
        /// </summary>
        public int AddressID;
        /// <summary>
        /// Phone ID
        /// </summary>
        public int PhoneID;
        /// <summary>
        /// Wage of Employee
        /// </summary>
        public decimal Wage;
        /// <summary>
        /// Employee SSN
        /// </summary>
        public string SSN;
        /// <summary>
        /// Employee Birth Date
        /// </summary>
        public DateTime BirthDate;
        /// <summary>
        /// Employee Start Date
        /// </summary>
        public DateTime StartDate;
        /// <summary>
        /// Employee End Date
        /// </summary>
        public DateTime EndDate;
        /// <summary>
        /// Employee Username
        /// </summary>
        public String UserName;
        /// <summary>
        /// Employee Password Hash
        /// </summary>
        public Guid PasswordHash;
        /// <summary>
        /// Employee Pin Hash
        /// </summary>
        public Guid PinHash;
        /// <summary>
        /// Employee Phone Number
        /// </summary>
        public Phone PhoneNumber;
        /// <summary>
        /// Employee Address
        /// </summary>
        public Address EmployeeAddress;
        /// <summary>
        /// Employee Position
        /// </summary>
        public Position EmployeePosition;
        #endregion
    }
}
