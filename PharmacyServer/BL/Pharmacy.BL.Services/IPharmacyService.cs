using System.Threading.Tasks;

namespace Pharmacy.BL.Contract
{
    public interface IPharmacyService
    {
        Task<> GetOrderedAsync(OrderType orderType);
    }
}
