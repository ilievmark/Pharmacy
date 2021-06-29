using System.Windows;
using Pharmacy.UI;
using Pharmacy.UI.ViewModel;
using Prism.Ioc;

namespace Pharmacy
{
    public partial class App
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainWindow, MainWindowViewModel>();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}
