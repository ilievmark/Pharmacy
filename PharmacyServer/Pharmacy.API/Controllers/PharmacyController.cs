using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.BL.Contract;
using Pharmacy.BL;
using Pharmacy.Domain;

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

        [HttpGet, Route("logIn")]
        public async Task<ActionResult> LogInAsync([FromRoute] OrderType order)
        {
            var serverResult = new ApiResult<string>();
            return Ok(serverResult);
        }
    }
}
