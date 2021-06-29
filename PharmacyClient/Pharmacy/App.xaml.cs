using System.Net.Http;
using System.Windows;
using Pharmacy.API;
using Pharmacy.API.Contract;
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
            containerRegistry.Register<IReportApi, ReportApi>();
            containerRegistry.Register<IPharmacyApi, PharmacyApi>();
            containerRegistry.Register<IPostApi, PostApi>();

            containerRegistry.RegisterForNavigation<MainWindow, MainWindowViewModel>();
            containerRegistry.RegisterForNavigation<PharmacyView, PharmacyViewModel>();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}
