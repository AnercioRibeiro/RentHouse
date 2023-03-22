using AutoMapper;
using Core.IRepository;
using Core.Models;
using Core.Specification;
using Microsoft.AspNetCore.Mvc;
using RentHouseAPI.DTOs;
using RentHouseAPI.Errors;
using RentHouseAPI.Helpers;


namespace RentHouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublicationsController : BaseAPIController
    {
        private readonly IGenericRepository<Publication> _publicationRepo;
        private readonly IGenericRepository<County> _countyRepo;
        private readonly IGenericRepository<Province> _provinceRepo;
        public readonly IMapper _mapper;

        public PublicationsController(IGenericRepository<Publication> publicationRepo, IGenericRepository<County> countyRepo, IMapper mapper, IGenericRepository<Province> provinceRepo)
        {
            _publicationRepo = publicationRepo;
            _countyRepo = countyRepo;
            _mapper = mapper;
            _provinceRepo = provinceRepo;
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

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PublicationToReturnDTO>> GetPublication(int id)
        {
            var spec = new PublicationWithProvincesAndCountiesSpecification(id);
            var publication = await _publicationRepo.GetEntityWithSpec(spec);
            if (publication == null) return NotFound(new ApiResponse(404));

            return _mapper.Map<Publication, PublicationToReturnDTO>(publication);
        }

        [HttpGet("counties")]
        public async Task<ActionResult<IReadOnlyList<County>>> GetCounties()
        {
            return Ok(await _countyRepo.ListAllAsync());
        }

        [HttpGet("provincies")]
        public async Task<ActionResult<IReadOnlyList<Province>>> GetProvincies()
        {
            return Ok(await _provinceRepo.ListAllAsync());
        }


    }
}
