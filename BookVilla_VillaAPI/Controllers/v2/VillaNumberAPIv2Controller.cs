using AutoMapper;
using BookVilla_VillaAPI.Models;
using BookVilla_VillaAPI.Models.DTO;
using BookVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Asp.Versioning;
using BookVilla_VillaAPI.Controllers.v1;

namespace BookVilla_VillaAPI.Controllers.v2
{
    [Route("api/v{version:apiVersion}/VillaNumberAPI")]
    [ApiController]
    [ApiVersion("2.0")]
    public class VillaNumberAPIv2Controller : ControllerBase
    {
        protected APIResponse _response;
        private readonly ILogger<VillaAPIController> _logger;
        private readonly IMapper _mapper;
        private readonly IVillaNumberRepository _repoVillaNumber;
        private readonly IVillaRepository _repo;

        public VillaNumberAPIv2Controller(ILogger<VillaAPIController> logger, IMapper mapper,
            IVillaNumberRepository repoVillaNumber, IVillaRepository repo)
        {
            _response = new();
            _logger = logger;
            _mapper = mapper;
            _repoVillaNumber = repoVillaNumber;
            _repo = repo;
        }

        [MapToApiVersion("2.0")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }
    }
}
