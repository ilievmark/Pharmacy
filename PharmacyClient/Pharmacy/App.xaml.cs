using System.Net.Http;
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
            containerRegistry.Register<HttpClient>();

            containerRegistry.RegisterForNavigation<MainWindow, MainWindowViewModel>();
            containerRegistry.RegisterForNavigation<PharmacyView, PharmacyViewModel>();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}
