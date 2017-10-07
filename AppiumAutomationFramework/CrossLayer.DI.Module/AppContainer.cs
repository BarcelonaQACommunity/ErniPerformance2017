using Autofac;
using Factory.SetUp;
using Pageobject.Appium.Factory.Pages.Appium;
using Pageobject.Factory.Contracts.Pages.Contracts;
using Pageobject.Web.Factory;

namespace CrossLayer.DI.Module
{
    /// <summary>
    /// The app container class.
    /// </summary>
    public static class AppContainer
    {
        /// <summary>
        /// Android container.
        /// </summary>
        public static IContainer AndroidContainer { get; private set; }

        /// <summary>
        /// Gets the web container.
        /// </summary>
        /// <value>
        /// The web container.
        /// </value>
        public static IContainer WebContainer { get; private set; }

        /// <summary>
        /// Initializes the <see cref="AppContainer"/> class.
        /// </summary>
        static AppContainer()
        {
            BuildAppAndroidContainer();
            BuildWebContainer();
        }

        /// <summary>
        /// Add all the android pages here.
        /// </summary>
        private static void BuildAppAndroidContainer()
        {
            var buildContainer = new ContainerBuilder();
            buildContainer.RegisterType<SetUpWebDriver>().As<ISetUpWebDriver>();
            buildContainer.RegisterType<AndroidMainViewPage>().As<IMainViewPage>();
            buildContainer.RegisterType<AndroidAddTaskPage>().As<IAddTaskPage>();
            buildContainer.RegisterType<AndroidEditTaskPage>().As<IEditTaskPage>();
            buildContainer.RegisterType<AndroidNewGroupPage>().As<INewGroupPage>();

            AndroidContainer = buildContainer.Build();
        }

        /// <summary>
        /// Add all the web pages here.
        /// </summary>
        private static void BuildWebContainer()
        {
            var buildContainer = new ContainerBuilder();
            buildContainer.RegisterType<SetUpWebDriver>().As<ISetUpWebDriver>();
            buildContainer.RegisterType<WebMainViewPage>().As<IMainViewPage>();
            buildContainer.RegisterType<WebAddTaskPage>().As<IAddTaskPage>();
            buildContainer.RegisterType<WebEditTaskPage>().As<IEditTaskPage>();

            WebContainer = buildContainer.Build();
        }
    }
}
