using BookVilla_VillaAPI.Data;
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
            return VillaStore.villaList;
        }
    }
}
