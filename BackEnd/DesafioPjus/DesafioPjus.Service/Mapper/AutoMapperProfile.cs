using AutoMapper;
using DesafioPjus.Domain.Cep;
using DesafioPjus.Service.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioPjus.Application.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ViaCepDto, Cep>();
            CreateMap<Cep, ViaCepDto>();
        }
    }
}
