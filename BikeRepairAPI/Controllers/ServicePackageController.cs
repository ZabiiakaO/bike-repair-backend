using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BikeRepairAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicePackageController : ControllerBase
    {
        private readonly StorageContext _storageContext;

        public ServicePackageController(StorageContext context)
        {
            _storageContext = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<ServicePackageRequest>>> GetBikeTypes()
        {
            return Ok(await _storageContext.ServicePackageRequests.ToListAsync());
        }
    }
}
