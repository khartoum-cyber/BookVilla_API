using BookVilla_VillaAPI.Models;
using BookVilla_VillaAPI.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BookVilla_VillaAPI.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return new List<VillaDTO>
            {
                new VillaDTO{Id=1,Name="Pool View"},
                new VillaDTO{Id=2,Name="Beach View"}
            };
        }
    }
}
