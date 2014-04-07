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
    /// A class for the Employee.
    /// </summary>
    public class Employee
    {
        #region Fields
        private int _id;
        private string _fName;
        private string _lName;
        private int _positionID;
        private int _addressID;
        private int _phoneID;
        private decimal _wage;
        private string _ssn;
        private DateTime _birthDate;
        private DateTime _startDate;
        private DateTime _endDate;
        private string _userName;
        private Guid _passwordHash;
        private Guid _pinHash;
        private Phone _phoneNumber;
        private Address _employeeAddress;
        private Position _employeePosition;
        #endregion

        #region Properties
        /// <summary>
        /// The ID of the employee.
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// The employee's First Name
        /// </summary>
        public string FName
        {
            get { return _fName; }
            set { _fName = value; }
        }
        /// <summary>
        /// The employee's Last Name.
        /// </summary>
        public string LName
        {
            get { return _lName; }
            set { _lName = value; }
        }
        /// <summary>
        /// The ID that is associated with the employees position.
        /// </summary>
        public int PostionID
        {
            get { return _positionID; }
            set { _positionID = value; }
        }
        /// <summary>
        /// The ID that is associated with the employees address.
        /// </summary>
        public int AddressID
        {
            get { return _addressID; }
            set { _addressID = value; }
        }
        /// <summary>
        /// The ID that is associated with the employees phone number.
        /// </summary>
        public int PhoneID
        {
            get { return _phoneID; }
            set { _phoneID = value; }
        }
        /// <summary>
        /// The employee's wage.
        /// </summary>
        public decimal Wage
        {
            get { return _wage; }
            set { _wage = value; }
        }
        /// <summary>
        /// The employee's Social Security Number.
        /// </summary>
        public string SSN
        {
            get { return _ssn; }
            set { _ssn = value; }
        }
        /// <summary>
        /// The employee's Birth Date.
        /// </summary>
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        /// <summary>
        /// The employee's hire date.
        /// </summary>
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        /// <summary>
        /// The employee's last day of employment.
        /// </summary>
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }
        /// <summary>
        /// The employee's Username. 
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        /// <summary>
        /// The Hash for the Password that belongs to the employee.
        /// </summary>
        public Guid PasswordHash
        {
            get { return _passwordHash; }
            set { _passwordHash = value; }
        }
        /// <summary>
        /// The Hash for the Pin Number that belongs to the employee.
        /// </summary>
        public Guid PinHash
        {
            get { return _pinHash; }
            set { _pinHash = value; }
        }
        /// <summary>
        /// The employee's Phone Number. Uses the Phone class.
        /// </summary>
        public Phone PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        /// <summary>
        /// The employee's Address. Uses the Address class.
        /// </summary>
        public Address EmployeeAddress
        {
            get { return _employeeAddress; }
            set { _employeeAddress = value; }
        }
        /// <summary>
        /// The Position of an employee. Uses the Position class.
        /// </summary>
        public Position EmployeePosition
        {
            get { return _employeePosition; }
            set { _employeePosition = value; }
        }
        #endregion
    }
}
