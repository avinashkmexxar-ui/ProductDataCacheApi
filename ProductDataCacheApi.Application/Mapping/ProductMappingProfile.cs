using AutoMapper;
using ProductDataCacheApi.Application.DTOs;
using ProductDataCacheApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDataCacheApi.Application.Mapping
{
    public sealed class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductDetailDto>();
        }
    }
}
