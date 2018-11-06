using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Temples.DataEntities.Models;
using Temples.Mapper.ModelEntities;

namespace Temples.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Temple, TempleEntity>();
        }
    }
}
