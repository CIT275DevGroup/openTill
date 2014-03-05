using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  24 Feb 2014
//Revisions:

namespace openTill.Domain
{
    public class Brand
    {
        #region Fields
        private int _id;
        private string _brandName;
        
        #endregion

        #region Properties

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string BrandName
        {
            get { return _brandName; }
            set { _brandName = value; }
        }
        
        #endregion
    }
}
