using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.BL.Contract;
using Pharmacy.DAL;
using Pharmacy.Domain;
using Pharmacy.Domain.Requests;

namespace Pharmacy.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IPerionService _perionService;

        public ReportController(
            IPerionService perionService)
        {
            _perionService = perionService;
        }

        [HttpPost, Route("period")]
        public async Task<ActionResult> AddPeriodAsync([FromBody] CreatePeriodRequest request)
        {
            try
            {
                var period = await _perionService.OpenPeriodAsync(request.Start);
                return Ok(new ApiResult<PeriodEntity>
                {
                    Result = period,
                    Status = Status.OK
                });
            }
            catch
            {
                return Ok(new ApiResult<PeriodEntity> { Status = Status.Error });
            }
        }

        [HttpGet, Route("period")] // by category
        public async Task<ActionResult> GetPeriodAsync(int perionId, string category)
        {
            var serverResult = new ApiResult<string>();
            return Ok(serverResult);
        }

        [HttpGet, Route("selled")]
        public async Task<ActionResult> GetSelledByPeriodAsync(int perionId)
        {
            var serverResult = new ApiResult<string>();
            return Ok(serverResult);
        }

        [HttpGet, Route("selling")]
        public async Task<ActionResult> GetSellingByPeriodAsync(int perionId)
        {
            var serverResult = new ApiResult<string>();
            return Ok(serverResult);
        }

        [HttpGet, Route("returned")]
        public async Task<ActionResult> GetReturnedByPeriodAsync(int perionId)
        {
            var serverResult = new ApiResult<string>();
            return Ok(serverResult);
        }
    }
}
