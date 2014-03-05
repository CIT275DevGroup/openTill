using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain.DTO
{
    public class SaleDTO
    {
        #region Properties

        public int Id;
        public decimal Total;
        public int EmployeeID;
        public DateTime DateOfSale;
        public List<SaleItemDTO> SaleItems;

        #endregion
    }
}
