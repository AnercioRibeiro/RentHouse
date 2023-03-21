using RentHouseAPI.Models;

namespace RentHouseAPI.Specification
{
    public class PublicationWithFiltersForCountSpecification : BaseSpecification<Publication>
    {
        public PublicationWithFiltersForCountSpecification(PublicationSpecParams publicationParams)
           : base(x =>
           (string.IsNullOrEmpty(publicationParams.Search) || x.Name.ToLower().Contains(publicationParams.Search)) &&
           (!publicationParams.ProvinceId.HasValue || x.PublicationProvinceId == publicationParams.ProvinceId) &&
           (!publicationParams.CountyId.HasValue || x.PublicationCountyId == publicationParams.CountyId))
        {

        }
    }
}
