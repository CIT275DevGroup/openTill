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
//Revisions:

namespace openTill.Domain.Services
{
    
    public class SaleService : ISaleService
    {
        #region fields

        private readonly ISaleRepository _saleRepository;

        #endregion

        #region Constructors

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
            _saleRepository.Insert(sale);
        }

        /// <summary>
        /// Method updates a sale that already exists in the database
        /// </summary>
        /// <param name="sale">Takes a single SaleDTO as an argument.</param>
        public void Update(SaleDTO sale)
        {
            _saleRepository.Update(sale);
        }

        /// <summary>
        /// Method returns all sales based on employee username.
        /// </summary>
        /// <param name="userName">Accepts a single username in the form of a string.</param>
        /// <returns></returns>
        public List<SaleDTO> GetSalesByEmployee(string userName)
        {
            var saleList = Mapper.Map<List<SaleDTO>>(_saleRepository.GetSalesByEmployee(userName));
            return saleList;
        }

        /// <summary>
        /// Method calculates sale total and tax.
        /// </summary>
        /// <param name="sale">Method takes on SaleDTO as an argument.</param>
        /// <returns></returns>
        public SaleDTO FinalizeSale(SaleDTO sale)
        {
            var saleTotal = sale.SaleItems.Aggregate(0m, (current, item) => current + item.SellingPrice);
            saleTotal = saleTotal + saleTotal * .06m;
            sale.DateOfSale = DateTime.Now;
            sale.Total = saleTotal;
            return sale;
        }

        #endregion
    }

     
}
