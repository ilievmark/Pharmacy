using System;
using System.Threading.Tasks;
using Pharmacy.BL.Contract;
using Pharmacy.DAL;
using Pharmacy.DAL.Contract;

namespace Pharmacy.BL.Services
{
    public class PeriodService : IPeriodService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PeriodService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<PeriodEntity> OpenPeriodAsync(DateTime start)
        {
            var periodRepository = _unitOfWork.GetRepository<PeriodEntity>();
            var period = new PeriodEntity();

            period.Start = start;

            await periodRepository.AddAsync(period);

            return period;
        }
    }
}
