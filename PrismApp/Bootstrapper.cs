using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Unity;
using PrismApp.Views;
using PrismModule1;
using PrismModule2;
using System.Windows;

namespace PrismApp
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            ModuleCatalog catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(PrismModule1Module));
            catalog.AddModule(typeof(PrismModule2Module));
        }
    }
}



