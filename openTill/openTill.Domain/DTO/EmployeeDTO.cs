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
    /// Employee data transfer object used to move an employee around the layers of the program.
    /// </summary>
    [ExcludeFromCodeCoverage ]  //Added By Blaine 4/18/2014
    public class EmployeeDTO
    {
        #region Properties
        public int ID;
        public string FName;
        public string LName;
        public int PositionID;
        public int AddressID;
        public int PhoneID;
        public decimal Wage;
        public string SSN;
        public DateTime BirthDate;
        public DateTime StartDate;
        public DateTime EndDate;
        public String UserName;
        public Guid PasswordHash;
        public Guid PinHash;
        public Phone PhoneNumber;
        public Address EmployeeAddress;
        public Position EmployeePosition;
        #endregion
    }
}
