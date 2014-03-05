using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain.DTO
{
    class SaleDTO
    {
        public int _id;
        public decimal _total;
        public int _employeeID;
        public DateTime _dateOfSale;
        public List<SaleItemDTO> _saleItems;
    }
}
