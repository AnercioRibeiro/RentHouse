using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RentHouseAPI.DTOs;
using RentHouseAPI.Helpers;
using RentHouseAPI.Models;
using RentHouseAPI.Repository.IRepository;
using RentHouseAPI.Specification;

namespace RentHouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublicationController : BaseAPIController
    {
        private readonly IGenericRepository<Publication> _publicationRepo;
        private readonly IGenericRepository<Owner> _ownerRepo;
        public readonly IMapper _mapper;

        public PublicationController(IGenericRepository<Publication> publicationRepo, IGenericRepository<Owner> ownerRepo, IMapper mapper)
        {
            _publicationRepo = publicationRepo;
            _ownerRepo = ownerRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<Pagination<PublicationToReturnDTO>>> GetPublications([FromQuery] PublicationSpecParams publicationParams)
        {
            var spec = new PublicationWithProvincesAndCountiesSpecification(publicationParams);
            var countSpec = new PublicationWithFiltersForCountSpecification(publicationParams);
            var totalItems = await _publicationRepo.CountAsync(countSpec);
            var publications = await _publicationRepo.ListAsync(spec);
            var data = _mapper.Map<IReadOnlyList<Publication>, IReadOnlyList<PublicationToReturnDTO>>(publications);
            return Ok(new Pagination<PublicationToReturnDTO>(publicationParams.PageIndex, publicationParams.PageSize, totalItems, data));
        }


    }
}
