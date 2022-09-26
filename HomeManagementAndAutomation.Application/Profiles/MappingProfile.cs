using AutoMapper;
using HomeManagementAndAutomation.Application.DTOs.ProductProperties;
using HomeManagementAndAutomation.Application.DTOs.Products;
using HomeManagementAndAutomation.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeManagementAndAutomation.Application.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();


            CreateMap<ProductProperty, CreateProductPropertyDto>().ReverseMap();
            CreateMap<ProductProperty, ProductPropertyDto>().ReverseMap();
        }
    }
}
