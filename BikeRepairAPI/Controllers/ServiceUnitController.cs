using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BikeRepairAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceUnitController : ControllerBase
    {
        private readonly StorageContext _storageContext;

        public ServiceUnitController(StorageContext context)
        {
            _storageContext = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<ServiceUnitRequest>>> GetBikeTypes()
        {
            return Ok(await _storageContext.ServiceUnitRequests.ToListAsync());
        }
    }
}
