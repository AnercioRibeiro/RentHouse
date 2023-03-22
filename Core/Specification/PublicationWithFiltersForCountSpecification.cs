using Core.Models;

namespace Core.Specification
{
    public class PublicationWithFiltersForCountSpecification : BaseSpecification<Publication>
    {
        public PublicationWithFiltersForCountSpecification(PublicationSpecParams publicationParams)
           : base(x =>
           (string.IsNullOrEmpty(publicationParams.Search) || x.Name.ToLower().Contains(publicationParams.Search)) &&
           (!publicationParams.ProvinceId.HasValue || x.ProvinceId == publicationParams.ProvinceId) &&
           (!publicationParams.CountyId.HasValue || x.CountyId == publicationParams.CountyId))
        {

        }
    }
}
