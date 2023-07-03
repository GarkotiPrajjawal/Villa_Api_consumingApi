using AutoMapper;
using Villa_Api_consumingApi.Models;
using Villa_Api_consumingApi.Models.Dto;

namespace Villa_Api_consumingApi
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<VillaOne, VillaDTO>();
            CreateMap<VillaDTO, VillaOne>();

            CreateMap<VillaOne, VillaCreateDTO>().ReverseMap();
            CreateMap<VillaOne, VillaUpdateDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberCreateDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberUpdateDTO>().ReverseMap();
        }
    }
}
