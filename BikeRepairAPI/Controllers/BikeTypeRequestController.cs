using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BikeRepairAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikeTypeRequestController : ControllerBase
    {
        private readonly StorageContext _storageContext;

        public BikeTypeRequestController(StorageContext context)
        {
            _storageContext = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<BikeTypeRequest>>> GetBikeTypes() 
        {
            return Ok(await _storageContext.BikeTypeRequests.ToListAsync());
        }
    }
}
