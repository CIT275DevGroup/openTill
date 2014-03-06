using System.Collections.Generic;
using openTill.Domain.DTO;

namespace openTill.Domain.Interface.Repository
{
    interface ISaleRepository
    {
        void Insert(SaleDTO sale);
        void Update(SaleDTO sale);
        IEnumerable<SaleDTO> GetSalesByEmployee(string userName);
    }
}
