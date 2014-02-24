using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain.DTO
{
    class EmployeeDTO
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
