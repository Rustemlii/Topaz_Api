﻿using AutoMapper;
using DataAccesLayer.Entity;
using DTO.DTOEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Config
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Score, ScoreDTO>();
            CreateMap<ScoreDTO,Score>();
        }

    }
}
