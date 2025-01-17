﻿using Application.Models;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Movie, MovieModel>().ReverseMap();
        }
    }
}