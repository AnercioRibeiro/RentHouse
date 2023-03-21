using RentHouseAPI.Models;

namespace RentHouseAPI.Specification
{
    public class PublicationWithProvincesAndCountiesSpecification : BaseSpecification<Publication>
    {
        public PublicationWithProvincesAndCountiesSpecification(PublicationSpecParams publicationParams)
        : base(x =>
              (string.IsNullOrEmpty(publicationParams.Search) || x.Name.ToLower().Contains(publicationParams.Search)) &&
              (!publicationParams.ProvinceId.HasValue || x.PublicationProvinceId == publicationParams.ProvinceId) && (!publicationParams.CountyId.HasValue || x.PublicationCountyId == publicationParams.CountyId))
        {
            AddInclude(x => x.Province);
            AddInclude(x => x.County);
            AddOrderBy(x => x.Name);
            ApplyPaging(publicationParams.PageSize * (publicationParams.PageIndex - 1), publicationParams.PageSize);

            if (!string.IsNullOrEmpty(publicationParams.Sort))
            {
                switch (publicationParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(n => n.Name);
                        break;
                }
            }
        }
        public PublicationWithProvincesAndCountiesSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.County);
            AddInclude(x => x.Province);
        }
    }
}
