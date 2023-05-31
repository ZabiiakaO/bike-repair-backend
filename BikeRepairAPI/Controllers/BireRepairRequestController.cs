using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BikeRepairAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BireRepairRequestController : ControllerBase
    {

        private readonly StorageContext _storageContext;

        public BireRepairRequestController(StorageContext context)
        {
            _storageContext = context;
        } 

        [HttpPost]

        public async Task<ActionResult<BikeRepairRequest>> PostBikeRepairRequest(BikeRepairRequest request)
        {
            _storageContext.Add(request);
            await _storageContext.SaveChangesAsync();

            return Ok(await _storageContext.BikeRepairRequests.ToListAsync());
        }

    }
}
