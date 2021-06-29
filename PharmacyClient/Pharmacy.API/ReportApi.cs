using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Pharmacy.API.Contract;
using Pharmacy.Domain;
using Pharmacy.Domain.Extensions;
using Pharmacy.Domain.Responses;

namespace Pharmacy.API
{
    public class ReportApi : BaseApiBinding, IReportApi
    {
        public ReportApi(HttpClient client) : base(client)
        {
        }

        public Task<ApiResult<PeriodReportResponse>> GetReportPeriodAsync(DateTime start, DateTime end, CancellationToken token, string category = null)
        {
            return _client.GetAsync(GetRequestUrl($"Report/period?start={start}&end={end}&category={category}"), token)
                          .ReadAsJsonAsync<ApiResult<PeriodReportResponse>>();
        }

        public Task<ApiResult<PeriodReportResponse>> GetSelledPeriodAsync(DateTime start, DateTime end, CancellationToken token)
        {
            return _client.GetAsync(GetRequestUrl($"Report/selled?start={start}&end={end}"), token)
                          .ReadAsJsonAsync<ApiResult<PeriodReportResponse>>();
        }

        public Task<ApiResult<PeriodReportResponse>> GetSellingPeriodAsync(DateTime start, DateTime end, CancellationToken token)
        {
            return _client.GetAsync(GetRequestUrl($"Report/selling?start={start}&end={end}"), token)
                          .ReadAsJsonAsync<ApiResult<PeriodReportResponse>>();
        }

        public Task<ApiResult<PeriodReportResponse>> GetReturnedPeriodAsync(DateTime start, DateTime end, CancellationToken token)
        {
            return _client.GetAsync(GetRequestUrl($"Report/returned?start={start}&end={end}"), token)
                          .ReadAsJsonAsync<ApiResult<PeriodReportResponse>>();
        }
    }
}