using AutoMapper;
using BookVilla_VillaAPI.Models.DTO;
using BookVilla_VillaAPI.Models;

namespace BookVilla_VillaAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, VillaDTOcreate>().ReverseMap();
            CreateMap<Villa, VillaDTOupdate>().ReverseMap();
        }
    }
}
