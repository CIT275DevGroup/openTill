using openTill.Domain.DTO;
using openTill.Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace openTill.Persistence
{
    // Author: Ryan Redburn
    // Project: openTill
    // Date: 4/9/2014

    public class SaleRepository : ISaleRepository
    {
        public IEnumerable<SaleDTO> GetSalesByEmployee(string employee)
        {
            // Throw exception for invalid employee value
            if (String.IsNullOrWhiteSpace(employee))
                throw new ArgumentNullException("employee",
                    "employee does not accept a null or empty string as an argument.");

            IEnumerable<SaleDTO> sales;

            // Open entity connection
            using (var context = new openTillEntities())
            {
                sales = Mapper.Map<IEnumerable<SaleDTO>>(context.Sales.Where(s => s.Employee.UserName == employee));
            }

            return sales;
        }

        public void Insert(SaleDTO sale)
        {
            // Throws an exception for an invalid sale value
            if (sale == null)
                throw new ArgumentNullException("sale", "sale does not accept a null dto as an argument.");

            // Reset sale ID
            sale.Id = 0;

            // Open entity connection
            using (var context = new openTillEntities())
            {
                context.Sales.Add(Mapper.Map<Sale>(sale));
                context.SaveChanges();
            }
        }

        public void Update(SaleDTO sale)
        {
            // Throws an exception for an invalid sale value
            if (sale == null)
                throw new ArgumentNullException("sale", "sale does not accept a null dto as an argument.");

            var saleUpdate = Mapper.Map<Sale>(sale);

            // Open entity connection
            using (var context = new openTillEntities())
            {
                // Retrieving sale to be updated
                var saleToUpdate = context.Sales.SingleOrDefault(s => s.Id == sale.Id);

                // Update sale properties
                saleToUpdate.DateOfSale = saleUpdate.DateOfSale;
                saleToUpdate.EmployeeId = saleUpdate.EmployeeId;
                saleToUpdate.Total = saleUpdate.Total;
                saleToUpdate.SaleItems = saleUpdate.SaleItems;

                context.SaveChanges();
            }
        }
    }
}
