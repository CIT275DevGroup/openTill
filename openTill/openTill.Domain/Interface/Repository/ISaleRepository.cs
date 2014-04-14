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
        /// <summary>
        /// Inserts a sale
        /// </summary>
        /// <param name="sale">Sale</param>
        void Insert(SaleDTO sale);
        /// <summary>
        /// Updates a sale
        /// </summary>
        /// <param name="sale">Sale</param>
        void Update(SaleDTO sale);
        /// <summary>
        /// List of Sales by Employee
        /// </summary>
        /// <param name="userName">Employee User Name</param>
        /// <returns>List of Sales</returns>
        IEnumerable<SaleDTO> GetSalesByEmployee(string userName);
    }
}
