using System.Collections.Generic;
using openTill.Domain.DTO;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  03 Mar 2014
//Revisions: 4/6/2014 Added Documentation | Curtis Reinhold

namespace openTill.Domain.Interface.Service
{
    /// <summary>
    /// An interface that calls on the ISaleRepository to perform the CRUD operations.
    /// </summary>
    public interface ISaleService
    {
        void Insert(SaleDTO sale);
        void Update(SaleDTO sale);
        List<SaleDTO> GetSalesByEmployee(string userName);
        SaleDTO FinalizeSale(SaleDTO sale);
    }
}