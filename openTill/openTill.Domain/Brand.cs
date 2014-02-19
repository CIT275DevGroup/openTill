using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain
{
    public class Brand
    {
        #region Fields
        private int _id;
        private string _brandName;
        #endregion

        #region Properties
        public int ID
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
