using System;
using System.Threading.Tasks;
using Pharmacy.Domain;
using Pharmacy.Domain.Responses;

namespace Pharmacy.API.Contract
{
    public interface IReportApi
    {
        Task<ApiResult<PeriodReportResponse>> GetReportPeriodAsync(DateTime start, DateTime end, string category = null);

        Task<ApiResult<PeriodReportResponse>> GetSelledPeriodAsync(DateTime start, DateTime end);

        Task<ApiResult<PeriodReportResponse>> GetSellingPeriodAsync(DateTime start, DateTime end);

        Task<ApiResult<PeriodReportResponse>> GetReturnedPeriodAsync(DateTime start, DateTime end);
    }
}