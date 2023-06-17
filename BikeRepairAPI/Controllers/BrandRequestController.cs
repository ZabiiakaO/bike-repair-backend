using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BikeRepairAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandRequestController : ControllerBase
    {
        private readonly StorageContext _storageContext;

        public BrandRequestController(StorageContext context)
        {
            _storageContext = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<BrandRequest>>> GetBikeTypes()
        {
            return Ok(await _storageContext.BrandRequests.ToListAsync());
        }
    }
}
