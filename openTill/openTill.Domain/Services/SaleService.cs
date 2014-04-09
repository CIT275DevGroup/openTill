using AutoMapper;
using openTill.Domain.DTO;
using openTill.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using openTill.Domain.Interface.Repository;
using openTill.Domain.Interface.Service;

//Author:  Morgan W. Davis III
//Project:  openTill Point of Sale System
//Date:  03 Mar 2014

#region [ Updates ]

// Author: Ryan Redburn
// Date: 4/9/2014
// Revisions: Added missing sale validation, simplified GetSalesByemployee() method, added additional commenting.

#endregion

namespace openTill.Domain.Services
{
    /// <summary>
    /// A road map to perform the CRUD operations for a Sale object.
    /// </summary>   
    public class SaleService : ISaleService
    {
        #region Fields

        private readonly ISaleRepository _saleRepository;

        #endregion

        #region Constructors

        /// <summary>
        /// A constructor that requires a repository as a parameter.
        /// </summary>
        /// <param name="saleRepository">Repository to be used.</param>
        public SaleService(ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Method inserts a new sale into the database
        /// </summary>
        /// <param name="sale">Takes a single SaleDTO as an argument.</param>
        public void Insert(SaleDTO sale)
        {
            // Validate new sale
            var newSale = Mapper.Map<Sale>(sale);

            // Commit new sale for persistence
            _saleRepository.Insert(Mapper.Map<SaleDTO>(newSale));
        }

        /// <summary>
        /// Method updates a sale that already exists in the database
        /// </summary>
        /// <param name="sale">Takes a single SaleDTO as an argument.</param>
        public void Update(SaleDTO sale)
        {
            // Validate updated sale
            var newSale = Mapper.Map<Sale>(sale);

            // Commit updated sale for persistence
            _saleRepository.Update(Mapper.Map<SaleDTO>(newSale));
        }

        /// <summary>
        /// Method returns all sales based on employee username.
        /// </summary>
        /// <param name="userName">Accepts a single username in the form of a string.</param>
        /// <returns></returns>
        public List<SaleDTO> GetSalesByEmployee(string userName)
        {
            // Map and return sale list received from persistence
            return Mapper.Map<List<SaleDTO>>(_saleRepository.GetSalesByEmployee(userName));
        }

        /// <summary>
        /// Method calculates sale total and tax.
        /// </summary>
        /// <param name="sale">Method takes on SaleDTO as an argument.</param>
        /// <returns></returns>
        public SaleDTO FinalizeSale(SaleDTO sale)
        {
            // Validate the given sale
            var saleFinal = Mapper.Map<Sale>(sale);

            // Perform logic for finalizing a sale
            var saleTotal = sale.SaleItems.Aggregate(0m, (current, item) => current + item.SellingPrice);
            saleTotal = saleTotal + (saleTotal * .06m);
            saleFinal.DateOfSale = DateTime.Now;
            saleFinal.Total = saleTotal;

            // Return the finalized sale
            return Mapper.Map<SaleDTO>(saleFinal);
        }

        #endregion
    }     
}
