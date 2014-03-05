using openTill.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Domain.Interface
{
    interface ISaleRepository
    {
        void Insert(SaleDTO sale);
        void Update(SaleDTO sale);
        IEnumerable<SaleDTO> GetSalesByEmployee(string userName);
    }
}
