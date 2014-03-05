using System.Collections.Generic;
using openTill.Domain.DTO;

namespace openTill.Domain.Interface.Service
{
    public interface ISaleService
    {
        void Insert(SaleDTO sale);
        void Update(SaleDTO sale);
        List<SaleDTO> GetSalesByEmployee(string userName);
        SaleDTO FinalizeSale(SaleDTO sale);
    }
}