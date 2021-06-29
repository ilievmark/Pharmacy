using System.Collections.Generic;
using System.Threading.Tasks;
using Pharmacy.BL.Contract;
using Pharmacy.DAL;

namespace Pharmacy.BL.Services
{
    public class PharmacyService : IPharmacyService
    {
        public PharmacyService()
        {
        }

        public Task<IEnumerable<PharmacyEntity>> GetOrderedAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
