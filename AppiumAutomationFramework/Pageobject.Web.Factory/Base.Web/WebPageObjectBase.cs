using CrossLayer.Configuration;
using Factory.SetUp;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Pageobject.Factory.Contracts.Base.Contracts;

namespace Pageobject.Web.Factory.Base.Web
{
    /// <summary>
    /// The web page object base class.
    /// </summary>
    /// <seealso cref="Pageobject.Factory.Contracts.Base.Contracts.IPageObjectBase" />
    public class WebPageObjectBase : IPageObjectBase
    {
        /// <summary>
        /// The set up web driver factory
        /// </summary>
        protected ISetUpWebDriver SetUpWebDriverFactory;

        /// <summary>
        /// The web driver
        /// </summary>
        protected IWebDriver WebDriver;

        //test
        [FindsBy(How = How.Id, Using = "textBox-itemTitle")]
        private IWebElement _taskTitleTextBox;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebPageObjectBase"/> class.
        /// </summary>
        /// <param name="setUpWebDriver">The set up web driver.</param>
        public WebPageObjectBase(ISetUpWebDriver setUpWebDriver)
        {
            SetUpWebDriverFactory = setUpWebDriver;

            if (ConfigurationDataService.Configuration.IsSauceLabs)
            {
                // TODO - Add saucelabs configuration.
            }
            else
            {
                WebDriver = setUpWebDriver.SetUpWebWebDriver();
            }
        }
    }
}
