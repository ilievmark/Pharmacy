using System.Threading;
using System.Threading.Tasks;
using Pharmacy.Domain;
using Pharmacy.Domain.Requests;
using Pharmacy.Domain.Responses;

namespace Pharmacy.API.Contract
{
    public interface IPostApi
    {
        Task<ApiResult<PharmacyEntryResponse>> CreateEntryAsync(CreatePharmacyEntryRequest request, CancellationToken token);

        Task<ApiResult<PharmacyEntryResponse>> ReturnEntryAsync(int entryId, CancellationToken token);

        Task<ApiResult<PharmacyEntryResponse>> ExpireEntryAsync(int entryId, CancellationToken token);

        Task<ApiResult<PharmacyEntryResponse>> PostEntryAsync(int entryId, CancellationToken token);
    }
}