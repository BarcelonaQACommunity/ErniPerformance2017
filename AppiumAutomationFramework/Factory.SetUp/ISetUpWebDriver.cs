using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Factory.SetUp
{
    /// <summary>
    /// The set up web driver interface.
    /// </summary>
    public interface ISetUpWebDriver
    {
        /// <summary>
        /// Sets up android web driver.
        /// </summary>
        /// <returns></returns>
        AppiumDriver<AndroidElement> SetUpAndroidWebDriver();

        /// <summary>
        /// Sets up android device driver.
        /// </summary>
        /// <returns></returns>
        AppiumDriver<AndroidElement> SetUpAndroidDeviceDriver();

        /// <summary>
        /// Sets up android sauce labs driver.
        /// </summary>
        /// <returns></returns>
        AppiumDriver<AndroidElement> SetUpAndroidSauceLabsDriver();

        /// <summary>
        /// Closes the android driver.
        /// </summary>
        void CloseAndroidDriver();

        /// <summary>
        /// Makes the screenshot.
        /// </summary>
        /// <param name="scenario">The scenario.</param>
        void MakeScreenshot(string scenario);
    }
}
