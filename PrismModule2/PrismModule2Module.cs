using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using PrismModule2.Views;
using System;

namespace PrismModule2
{
    public class PrismModule2Module : IModule
    {
        IUnityContainer _unityContainer;

        public PrismModule2Module(IUnityContainer unityContainer)
        {
            _unityContainer = unityContainer;
        }

        public void Initialize()
        {
            this._unityContainer.RegisterTypeForNavigation<Administrator>();
        }
    }
}