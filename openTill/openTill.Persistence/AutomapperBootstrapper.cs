using AutoMapper;
using openTill.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openTill.Persistence
{
    public static class AutomapperBootstrapper
    {
        public static void Initialize()
        {
            Mapper.CreateMap<openTill.Persistence.Product, ProductDTO>();
            Mapper.CreateMap<openTill.Persistence.Brand, BrandDTO>();
            Mapper.CreateMap<openTill.Persistence.Category, CategoryDTO>();
            Mapper.CreateMap<openTill.Persistence.Employee, EmployeeDTO>();
            Mapper.CreateMap<ProductDTO, openTill.Persistence.Product>();
            Mapper.CreateMap<BrandDTO, openTill.Persistence.Brand>();
            Mapper.CreateMap<CategoryDTO, openTill.Persistence.Category>();
            Mapper.CreateMap<EmployeeDTO, openTill.Persistence.Employee>();
        }
    }
}
