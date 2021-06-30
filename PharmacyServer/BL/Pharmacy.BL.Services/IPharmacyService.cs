using System.Collections.Generic;
using System.Threading.Tasks;
using Pharmacy.DAL;

namespace Pharmacy.BL.Contract
{
    public interface IPharmacyService
    {
        Task<IEnumerable<PharmacyEntity>> GetOrderedAsync();
    }
}
