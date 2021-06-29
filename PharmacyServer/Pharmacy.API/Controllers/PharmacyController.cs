using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.BL.Contract;
using Pharmacy.Domain;
using Pharmacy.Domain.Requests;

namespace Pharmacy.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PharmacyController : ControllerBase
    {
        private IPharmacyService _pharmacyService;

        public PharmacyController(
            IPharmacyService pharmacyService)
        {
            _pharmacyService = pharmacyService;
        }

        [HttpGet, Route("pharmacy")]
        public async Task<ActionResult> GetAllPharmacyAsync(string name, string category, decimal price)
        {
            var serverResult = new ApiResult<string>();
            return Ok(serverResult);
        }

        [HttpGet, Route("pharmacy/critical")]
        public async Task<ActionResult> GetCriticalPharmacyAsync(int maxDays, string name, string category, decimal price)
        {
            var serverResult = new ApiResult<string>();
            return Ok(serverResult);
        }

        [HttpPost, Route("pharmacy")]
        public async Task<ActionResult> CreatePharmacyAsync([FromBody] CreatePharmacyRequest createPharmacyRequest)
        {
            var serverResult = new ApiResult<string>();
            return Ok(serverResult);
        }
    }
}
