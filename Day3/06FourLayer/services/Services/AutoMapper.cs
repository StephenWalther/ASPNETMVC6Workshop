using AutoMapper;
using Domain.Models;
using Services.Models;
using System;

namespace Services
{
    public class AutoMapper
    {
        public static void Map()
        {
            Mapper.CreateMap<Product, BriefProductDTO>();
            Mapper.CreateMap<Product, FullProductDTO>();
            Mapper.CreateMap<FullProductDTO, Product>();
        }
    }
}