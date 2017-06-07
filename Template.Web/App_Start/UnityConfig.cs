using Microsoft.Practices.Unity;
using System;

namespace Template.Web
{
    public static class UnityConfig
    {

        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static void RegisterTypes(UnityContainer container)
        {

        }

        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
    }
}