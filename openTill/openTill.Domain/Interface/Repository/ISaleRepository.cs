using System.Collections.Generic;
using openTill.Domain.DTO;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  03 Mar 2014
//Revisions: 4/6/2014 Added Documentation | Curtis Reinhold

namespace openTill.Domain.Interface.Repository
{
    /// <summary>
    /// An interface that performs the CRUD operations for a Sale object.
    /// </summary>
    public interface ISaleRepository
    {
        void Insert(SaleDTO sale);
        void Update(SaleDTO sale);
        IEnumerable<SaleDTO> GetSalesByEmployee(string userName);
    }
}
