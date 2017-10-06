using Autofac;
using Pageobject.Appium.Factory.Pages.Appium;
using Pageobject.Factory.Contracts.Pages.Contracts;

namespace CrossLayer.DI.Module
{
    public static class AppContainer
    {
        /// <summary>
        /// Android container.
        /// </summary>
        public static IContainer AndroidContainer { get; private set; }

        /// <summary>
        /// Initializes the <see cref="AppContainer"/> class.
        /// </summary>
        static AppContainer()
        {
            AppAndroidContainer();
        }

        /// <summary>
        /// Add all the android pages here.
        /// </summary>
        private static void AppAndroidContainer()
        {
            var buildContainer = new ContainerBuilder();
            buildContainer.RegisterType<AndroidMainViewPage>().As<IMainViewPage>();
            buildContainer.RegisterType<AndroidAddTaskPage>().As<IAddTaskPage>();
            buildContainer.RegisterType<AndroidEditTaskPage>().As<IEditTaskPage>();
            buildContainer.RegisterType<AndroidNewGroupPage>().As<INewGroupPage>();

            AndroidContainer = buildContainer.Build();
        }
    }
}
