using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Pharmacy.API.Contract;
using Pharmacy.Domain;
using Pharmacy.Domain.Extensions;
using Pharmacy.Domain.Requests;
using Pharmacy.Domain.Responses;

namespace Pharmacy.API
{
    public class PharmacyApi : BaseApiBinding, IPharmacyApi
    {
        public PharmacyApi(HttpClient client) : base(client)
        {
        }

        public Task<ApiResult<PharmacyListResponse>> GetAllPharmacyAsync(string name, string category, decimal price, CancellationToken token)
        {
            return _client.GetAsync(GetRequestUrl($"Pharmacy/pharmacy?name={name}&category={category}&price={price}"), token)
                          .ReadAsJsonAsync<ApiResult<PharmacyListResponse>>();
        }

        public Task<ApiResult<PharmacyListResponse>> GetAllCriticalPharmacyAsync(int maxDays, string name, string category, decimal price, CancellationToken token)
        {
            return _client.GetAsync(GetRequestUrl($"Pharmacy/pharmacy/critical?maxDays={maxDays}&name={name}&category={category}&price={price}"), token)
                          .ReadAsJsonAsync<ApiResult<PharmacyListResponse>>();
        }

        public Task<ApiResult<PharmacyCreateResponse>> CreatePharmacyAsync(CreatePharmacyRequest request, CancellationToken token)
        {
            return _client.PostAsync(GetRequestUrl("Pharmacy/pharmacy"), request, token)
                          .ReadAsJsonAsync<ApiResult<PharmacyCreateResponse>>();
        }
    }
}