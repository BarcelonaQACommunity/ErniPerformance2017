using Factory.SetUp;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using Pageobject.Factory.Contracts.Base.Contracts;

namespace Pageobject.Appium.Factory.Base.Appium
{
    /// <summary>
    /// The page object base class.
    /// </summary>
    /// <seealso cref="Pageobject.Factory.Contracts.Base.Contracts.IPageObjectBase" />
    public class AndroidPageObjectBase : IPageObjectBase
    {
        /// <summary>
        /// The android driver.
        /// Used for all the factory to interact with the elements.
        /// </summary>
        protected AppiumDriver<AndroidElement> AndroidDriver;

        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidPageObjectBase"/> class.
        /// </summary>
        public AndroidPageObjectBase()
        {
            this.AndroidDriver = SetUpWebDriver.SetUpAppiumDriver();
        }

        /// <summary>
        /// Sets up default configuration.
        /// </summary>
        protected void SetUpDefaultConfiguration()
        {
            this.AndroidDriver = SetUpWebDriver.SetUpAppiumDriver();

            // If required, add more default configuration values.
        }
    }
}
