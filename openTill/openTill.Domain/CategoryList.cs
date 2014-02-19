using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain
{
    public class CategoryList
    {
        #region Fields
        private int _id;
        private string _productUPC;
        private int _categoryID;
        #endregion

        #region Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string ProductUPC
        {
            get { return _productUPC; }
            set { _productUPC = value; }
        }

        public int CategoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }
        #endregion
    }
}
