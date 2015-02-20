using AutoMapper;
using Domain.Models;
using Services.Models;
using System;

namespace Services
{
    public class AutoMapperStartup
    {
        public static void RegisterMaps()
        {
            Mapper.CreateMap<Product, BriefProductDTO>();
            Mapper.CreateMap<Product, FullProductDTO>();
            Mapper.CreateMap<FullProductDTO, Product>();
        }
    }
}