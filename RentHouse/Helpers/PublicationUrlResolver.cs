using AutoMapper;
using Core.Models;
using RentHouseAPI.DTOs;


namespace RentHouseAPI.Helpers
{

        public class PublicationUrlResolver : IValueResolver<Publication, PublicationToReturnDTO, string>
        {
            public readonly IConfiguration _config;
            public PublicationUrlResolver(IConfiguration config)
            {
                _config = config;
            }
            public string Resolve(Publication source, PublicationToReturnDTO destination, string destMember, ResolutionContext context)
            {
                if (!string.IsNullOrEmpty(source.PictureUrl))
                {
                    return _config["ApiUrl"] + source.PictureUrl;
                }

                return null;
            }
        }
}
