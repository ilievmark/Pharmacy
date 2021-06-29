using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace Pharmacy.UI.ViewModel
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            ViewPharmacy = new DelegateCommand(OnViewPharmacy);
        }

        public ICommand ViewPharmacy { get; }

        private void OnViewPharmacy()
        {
            
        }
    }
}