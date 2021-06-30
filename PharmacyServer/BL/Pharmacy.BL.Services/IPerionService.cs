using System;
using System.Threading.Tasks;
using Pharmacy.DAL;

namespace Pharmacy.BL.Contract
{
    public interface IPeriodService
    {
        Task<PeriodEntity> OpenPeriodAsync(DateTime start);
    }
}
