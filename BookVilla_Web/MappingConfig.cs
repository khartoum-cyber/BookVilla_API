using AutoMapper;
using BookVilla_Web.Models.DTO;

namespace BookVilla_Web
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<VillaDTO, VillaDTOcreate>().ReverseMap();
            CreateMap<VillaDTO, VillaDTOupdate>().ReverseMap();

            CreateMap<VillaNumberDTO, VillaNumberDTOcreate>().ReverseMap();
            CreateMap<VillaNumberDTO, VillaNumberDTOupdate>().ReverseMap();
        }
    }
}
