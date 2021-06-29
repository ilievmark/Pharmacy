using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Domain;
using Pharmacy.Domain.Requests;

namespace Pharmacy.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        public PostController()
        {
        }

        [HttpPost, Route("pharmacy/entry")]
        public async Task<ActionResult> AddNewEntryOfPharmacyAsync([FromBody] CreatePharmacyEntryRequest createPharmacyEntryRequest)
        {
            var serverResult = new ApiResult<string>();
            return Ok(serverResult);
        }

        [HttpPut, Route("pharmacy/return")]
        public async Task<ActionResult> ReturnEntryOfPharmacyAsync(int entryId)
        {
            var serverResult = new ApiResult<string>();
            return Ok(serverResult);
        }

        [HttpPut, Route("pharmacy/expire")]
        public async Task<ActionResult> ExpireEntryOfPharmacyAsync(int entryId)
        {
            var serverResult = new ApiResult<string>();
            return Ok(serverResult);
        }

        [HttpPut, Route("pharmacy/post")]
        public async Task<ActionResult> PostEntryOfPharmacyAsync(int entryId)
        {
            var serverResult = new ApiResult<string>();
            return Ok(serverResult);
        }
    }
}
