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

        public Task<ApiResult<PeriodReportResponse>> GetReportPeriodAsync(int periodId, string category, CancellationToken token)
        {
            return _client.GetAsync(GetRequestUrl($"Report/period?periodId={periodId}&category={category}"), token)
                          .ReadAsJsonAsync<ApiResult<PeriodReportResponse>>();
        }

        public Task<ApiResult<PeriodReportResponse>> GetSelledPeriodAsync(int periodId, CancellationToken token)
        {
            return _client.GetAsync(GetRequestUrl($"Report/selled?periodId={periodId}"), token)
                          .ReadAsJsonAsync<ApiResult<PeriodReportResponse>>();
        }

        public Task<ApiResult<PeriodReportResponse>> GetSellingPeriodAsync(int periodId, CancellationToken token)
        {
            return _client.GetAsync(GetRequestUrl($"Report/selling?periodId={periodId}"), token)
                          .ReadAsJsonAsync<ApiResult<PeriodReportResponse>>();
        }

        public Task<ApiResult<PeriodReportResponse>> GetReturnedPeriodAsync(int periodId, CancellationToken token)
        {
            return _client.GetAsync(GetRequestUrl($"Report/returned?periodId={periodId}"), token)
                          .ReadAsJsonAsync<ApiResult<PeriodReportResponse>>();
        }
    }
}