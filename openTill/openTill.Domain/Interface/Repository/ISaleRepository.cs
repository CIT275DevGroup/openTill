using System.Collections.Generic;
using openTill.Domain.DTO;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  03 Mar 2014
//Revisions:

namespace openTill.Domain.Interface.Repository
{
    public interface ISaleRepository
    {
        void Insert(SaleDTO sale);
        void Update(SaleDTO sale);
        IEnumerable<SaleDTO> GetSalesByEmployee(string userName);
    }
}
