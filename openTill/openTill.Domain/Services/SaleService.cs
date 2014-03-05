using AutoMapper;
using openTill.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using openTill.Domain.Interface.Repository;
using openTill.Domain.Interface.Service;

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

        public void Insert(SaleDTO sale)
        {
            _saleRepository.Insert(sale);
        }

        public void Update(SaleDTO sale)
        {
            _saleRepository.Update(sale);
        }

        public List<SaleDTO> GetSalesByEmployee(string userName)
        {
            var saleList = Mapper.Map<List<SaleDTO>>(_saleRepository.GetSalesByEmployee(userName));
            return saleList;
        }

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
