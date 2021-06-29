using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Domain;

namespace Pharmacy.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        public ReportController()
        {
        }

        [HttpGet, Route("period")] // by category
        public async Task<ActionResult> GetPeriodAsync(DateTime start, DateTime end)
        {
            var serverResult = new ApiResult<string>();
            return Ok(serverResult);
        }

        [HttpGet, Route("period/report")] // by category
        public async Task<ActionResult> GetPeriodAsync(string category, DateTime start, DateTime end)
        {
            var serverResult = new ApiResult<string>();
            return Ok(serverResult);
        }

        [HttpGet, Route("selled")]
        public async Task<ActionResult> GetSelledByPeriodAsync(DateTime start, DateTime end)
        {
            var serverResult = new ApiResult<string>();
            return Ok(serverResult);
        }

        [HttpGet, Route("selling")]
        public async Task<ActionResult> GetSellingByPeriodAsync(DateTime start, DateTime end)
        {
            var serverResult = new ApiResult<string>();
            return Ok(serverResult);
        }

        [HttpGet, Route("returned")]
        public async Task<ActionResult> GetReturnedByPeriodAsync(DateTime start, DateTime end)
        {
            var serverResult = new ApiResult<string>();
            return Ok(serverResult);
        }
    }
}
