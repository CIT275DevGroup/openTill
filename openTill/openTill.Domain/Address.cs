using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain
{
    class Address
    {
        #region Fields
        private int _id;
        private string _street;
        private string _city;
        private int _stateID;
        private int _zipID;
        #endregion

        #region Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public int StateID
        {
            get { return _stateID; }
            set { _stateID = value; }
        }

        public int ZipID
        {
            get { return _zipID; }
            set { _zipID = value; }
        }
        #endregion
    }
}
