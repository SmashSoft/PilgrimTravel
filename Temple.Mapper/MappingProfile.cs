using AutoMapper;
using Temples.DataEntities.Models;
using Temples.ViewMapper.ModelEntities;

namespace Temples.ViewMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Temple, TempleViewModel>().ReverseMap()
                ;
            
        }
    }
}
