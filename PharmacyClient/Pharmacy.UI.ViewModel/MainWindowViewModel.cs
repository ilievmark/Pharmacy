using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace Pharmacy.UI.ViewModel
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        public MainWindowViewModel(
            IRegionManager regionManager)
        {
            _regionManager = regionManager;
            ViewPharmacy = new DelegateCommand(OnViewPharmacy);
            ViewReports = new DelegateCommand(OnViewReports);
        }

        public ICommand ViewPharmacy { get; }

        public ICommand ViewReports { get; }

        private void OnViewPharmacy()
        {
            _regionManager.RequestNavigate("MainRegion", "PharmacyView");
        }

        private void OnViewReports()
        {
        }
    }
}