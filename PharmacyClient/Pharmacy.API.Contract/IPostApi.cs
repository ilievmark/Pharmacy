using System.Threading.Tasks;
using Pharmacy.Domain;
using Pharmacy.Domain.Requests;
using Pharmacy.Domain.Responses;

namespace Pharmacy.API.Contract
{
    public interface IPostApi
    {
        Task<ApiResult<PharmacyEntryResponse>> CreateEntryAsync(CreatePharmacyEntryRequest request);

        Task<ApiResult<PharmacyEntryResponse>> ReturnEntryAsync(int entryId);

        Task<ApiResult<PharmacyEntryResponse>> ExpireEntryAsync(int entryId);

        Task<ApiResult<PharmacyEntryResponse>> PostEntryAsync(int entryId);
    }
}