using System.Collections.Generic;
using openTill.Domain.DTO;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  03 Mar 2014
//Revisions:

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