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
        /// <summary>
        /// Inserts a sale
        /// </summary>
        /// <param name="sale"></param>
        void Insert(SaleDTO sale);
        /// <summary>
        /// Updates a sale
        /// </summary>
        /// <param name="sale"></param>
        void Update(SaleDTO sale);
        /// <summary>
        /// Gets sales by employee      
        /// </summary>
        /// <param name="userName">Employee username</param>
        /// <returns>List of Sales</returns>
        List<SaleDTO> GetSalesByEmployee(string userName);
        /// <summary>
        /// Finalize the sale
        /// </summary>
        /// <param name="sale">Sale</param>
        /// <returns>SaleDTO</returns>
        SaleDTO FinalizeSale(SaleDTO sale);
    }
}