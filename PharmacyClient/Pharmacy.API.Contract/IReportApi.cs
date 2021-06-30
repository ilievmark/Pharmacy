using System;
using System.Threading;
using System.Threading.Tasks;
using Pharmacy.DAL;
using Pharmacy.Domain;
using Pharmacy.Domain.Responses;

namespace Pharmacy.API.Contract
{
    public interface IReportApi
    {
        Task<ApiResult<PeriodEntry>> AddPeriod();

        Task<ApiResult<PeriodReportResponse>> GetReportPeriodAsync(int periodId, string category, CancellationToken token);

        Task<ApiResult<PeriodReportResponse>> GetSelledPeriodAsync(int periodId, CancellationToken token);

        Task<ApiResult<PeriodReportResponse>> GetSellingPeriodAsync(int periodId, CancellationToken token);

        Task<ApiResult<PeriodReportResponse>> GetReturnedPeriodAsync(int periodId, CancellationToken token);
    }
}