using System.Threading.Tasks;
using Pharmacy.Domain;
using Pharmacy.Domain.Requests;
using Pharmacy.Domain.Responses;

namespace Pharmacy.API.Contract
{
    public interface IPharmacyApi
    {
        Task<ApiResult<PharmacyListResponse>> GetAllPharmacyAsync(string name, string category, decimal price);

        Task<ApiResult<PharmacyListResponse>> GetAllCriticalPharmacyAsync(int maxDays, string name, string category, decimal price);

        Task<ApiResult<PharmacyCreateResponse>> CreatePharmacyAsync(CreatePharmacyRequest request);
    }
}