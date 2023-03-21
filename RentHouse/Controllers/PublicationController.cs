using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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


    }
}
