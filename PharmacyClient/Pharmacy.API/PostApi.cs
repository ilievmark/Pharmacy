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
    public class PostApi : BaseApiBinding, IPostApi
    {
        public PostApi(HttpClient client) : base(client)
        {
        }

        public Task<ApiResult<PharmacyEntryResponse>> CreateEntryAsync(CreatePharmacyEntryRequest request, CancellationToken token)
        {
            return _client.PostAsync(GetRequestUrl("Post/pharmacy/entry"), request, token)
                          .ReadAsJsonAsync<ApiResult<PharmacyEntryResponse>>();
        }

        public Task<ApiResult<PharmacyEntryResponse>> ReturnEntryAsync(int entryId, CancellationToken token)
        {
            return _client.PutAsync(GetRequestUrl($"Post/pharmacy/return?entryId={entryId}"), null, token)
                          .ReadAsJsonAsync<ApiResult<PharmacyEntryResponse>>();
        }

        public Task<ApiResult<PharmacyEntryResponse>> ExpireEntryAsync(int entryId, CancellationToken token)
        {
            return _client.PutAsync(GetRequestUrl($"Post/pharmacy/expire?entryId={entryId}"), null, token)
                          .ReadAsJsonAsync<ApiResult<PharmacyEntryResponse>>();
        }

        public Task<ApiResult<PharmacyEntryResponse>> PostEntryAsync(int entryId, CancellationToken token)
        {
            return _client.PutAsync(GetRequestUrl($"Post/pharmacy/post?entryId={entryId}"), null, token)
                          .ReadAsJsonAsync<ApiResult<PharmacyEntryResponse>>();
        }
    }
}
