using AutoMapper;
using RentHouseAPI.DTOs;
using RentHouseAPI.Models;

namespace RentHouseAPI.Helpers
{
    public class MappingProfiles : Profile
    {

        public MappingProfiles()
        {
            CreateMap<Publication, PublicationToReturnDTO>()
                .ForMember(d => d.Province, o => o.MapFrom(s => s.Province.Name))
                .ForMember(d => d.Country, o => o.MapFrom(s => s.County.Name))
                .ForMember(d => d.PictureUrl, o => o.MapFrom<PublicationUrlResolver>());
        }
    }
}

