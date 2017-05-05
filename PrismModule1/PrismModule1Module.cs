using Prism.Modularity;
using Microsoft.Practices.Unity;
using Prism.Unity;
using PrismModule1.Views;

namespace PrismModule1
{
    public class PrismModule1Module : IModule
    {
        IUnityContainer _unityContainer;

        public PrismModule1Module(IUnityContainer unityContainer)
        {
            _unityContainer = unityContainer;
        }

        public void Initialize()
        {
            this._unityContainer.RegisterTypeForNavigation<User>();
        }
    }
}