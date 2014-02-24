using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain
{
    class Employee
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
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FName
        {
            get { return _fName; }
            set { _fName = value; }
        }

        public string LName
        {
            get { return _lName; }
            set { _lName = value; }
        }

        public int PostionID
        {
            get { return _positionID; }
            set { _positionID = value; }
        }

        public int AddressID
        {
            get { return _addressID; }
            set { _addressID = value; }
        }

        public int PhoneID
        {
            get { return _phoneID; }
            set { _phoneID = value; }
        }

        public decimal Wage
        {
            get { return _wage; }
            set { _wage = value; }
        }

        public string SSN
        {
            get { return _ssn; }
            set { _ssn = value; }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public Guid PasswordHash
        {
            get { return _passwordHash; }
            set { _passwordHash = value; }
        }

        public Guid PinHash
        {
            get { return _pinHash; }
            set { _pinHash = value; }
        }

        public Phone PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public Address EmployeeAddress
        {
            get { return _employeeAddress; }
            set { _employeeAddress = value; }
        }

        public Position EmployeePosition
        {
            get { return _employeePosition; }
            set { _employeePosition = value; }
        }
        #endregion
    }
}
