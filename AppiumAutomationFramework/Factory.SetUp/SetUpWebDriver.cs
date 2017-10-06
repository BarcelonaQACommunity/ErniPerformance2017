using System;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using CrossLayer.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace Factory.SetUp
{
    /// <summary>
    /// Initialize the Appium Driver.
    /// </summary>
    public static class SetUpWebDriver
    {
        private const string AndroidApplicationPath = @"\Factory.SetUp\binaries\mylist.apk";

        /// <summary>
        /// Appium Driver.
        /// </summary>
        public static AppiumDriver<AndroidElement> AppiumDriver { get; private set; }

        /// <summary>
        /// See Wiki to set up the desired capabilities.
        /// <seealso cref="https://wiki.saucelabs.com/display/DOCS/Desired+Capabilities+Required+for+Selenium+and+Appium+Tests"/>
        /// See Wiki to use the Platform Configuration tool.
        /// <seealso cref="https://wiki.saucelabs.com/display/DOCS/Platform+Configurator#/"/>
        /// See Wiki to see the supported android emulator devices.
        /// <seealso cref="https://wiki.saucelabs.com/display/DOCS/Supported+Android+Emulators"/>
        /// </summary>
        public static AppiumDriver<AndroidElement> SetUpAppiumDriver()
        {
            if (AppiumDriver != null)
            {
                return AppiumDriver;
            }

            // Parameter to set saucelabs dashboard configuration in order to add the current scenario and if fails or not the test
            Configuration.IsSaucelabsConfiguration = false;

            var appFullPath = Directory.GetParent(Directory.GetCurrentDirectory()) + AndroidApplicationPath;

            // Set up capabilities.
            // See Appium Capabilities wiki.
            var capabilities = new DesiredCapabilities();
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("platformVersion", "7");
            capabilities.SetCapability("fastReset", true);
            capabilities.SetCapability("app", appFullPath);

            // To see the device name with the cmd console check adb devices -l
            capabilities.SetCapability("deviceName", "vbox86p");

            AppiumDriver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities, TimeSpan.FromSeconds(60));

            return AppiumDriver;
        }

        /// <summary>
        /// See Wiki to set up the desired capabilities.
        /// <seealso cref="https://wiki.saucelabs.com/display/DOCS/Desired+Capabilities+Required+for+Selenium+and+Appium+Tests"/>
        /// </summary>
        public static AppiumDriver<AndroidElement> SetUpAppiumLocalDriver()
        {
            if (AppiumDriver != null)
            {
                return AppiumDriver;
            }

            // Parameter to set saucelabs dashboard configuration in order to add the current scenario and if fails or not the test
            Configuration.IsSaucelabsConfiguration = false;

            var appFullPath = Directory.GetParent(Directory.GetCurrentDirectory()) + AndroidApplicationPath;

            // Set up capabilities.
            // See Appium Capabilities wiki.
            var capabilities = new DesiredCapabilities();
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("platformVersion", "6.0.1");
            capabilities.SetCapability("fastReset", "True");
            capabilities.SetCapability("app", appFullPath);

            // To see the device name with the cmd console check adb devices -l
            capabilities.SetCapability("deviceName", "trlte");

            AppiumDriver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities, TimeSpan.FromSeconds(600));

            return AppiumDriver;
        }

        /// <summary>
        /// See Wiki to set up the desired capabilities.
        /// <seealso cref="https://wiki.saucelabs.com/display/DOCS/Desired+Capabilities+Required+for+Selenium+and+Appium+Tests"/>
        /// Upload app: curl -u erniqa:4e3d7e6a-0694-4794-8722-e4fcc6aef6e7 -X POST -H "Content-Type: application/octet-stream" https://saucelabs.com/rest/v1/storage/erniqa/mylist.apk?overwrite=true --data-binary @/mylist.apk
        /// See Wiki to use the Platform Configuration tool.
        /// <seealso cref="https://wiki.saucelabs.com/display/DOCS/Platform+Configurator#/"/>
        /// See Wiki to see the supported android emulator devices.
        /// <seealso cref="https://wiki.saucelabs.com/display/DOCS/Supported+Android+Emulators"/>
        /// </summary>
        public static AppiumDriver<AndroidElement> SetUpAppiumSauceLabsDriver()
        {
            if (AppiumDriver != null)
            {
                return AppiumDriver;
            }

            // Parameter to set saucelabs dashboard configuration in order to add the current scenario and if fails or not the test
            Configuration.IsSaucelabsConfiguration = true;

            var capabilities = new DesiredCapabilities();
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("platformVersion", "7.0");
            capabilities.SetCapability("deviceName", "Android GoogleAPI Emulator");
            capabilities.SetCapability("app", "sauce-storage:mylist.apk");
            capabilities.SetCapability("username", "Outsource");
            capabilities.SetCapability("accessKey", "e2cb260f-7805-4685-828e-af1065b61447");
            capabilities.SetCapability("name", Configuration.CurrentScenario);

            AppiumDriver = new AndroidDriver<AndroidElement>(new Uri("http://ondemand.saucelabs.com:80/wd/hub"), capabilities, TimeSpan.FromSeconds(600));

            return AppiumDriver;
        }

        /// <summary>
        /// Closes the android driver.
        /// </summary>
        public static void CloseAndroidDriver()
        {
            if (Configuration.IsSaucelabsConfiguration)
            {
                ((IJavaScriptExecutor)AppiumDriver).ExecuteScript("sauce:job-result=" + (Configuration.IsPass ? "passed" : "failed"));
            }

            AppiumDriver?.Dispose();
            AppiumDriver = null;
        }

        /// <summary>
        /// Makes the screenshot.
        /// </summary>
        /// <param name="scenario">The scenario.</param>
        public static void MakeScreenshot(string scenario)
        {
            var screenshot = ((ITakesScreenshot) AppiumDriver).GetScreenshot();
            var dateTime = $"{DateTime.Now.ToString("d-M-yyyy HH-mm-ss", CultureInfo.InvariantCulture)}_{scenario}.jpeg";
            screenshot.SaveAsFile(dateTime, ImageFormat.Jpeg);
        }
    }
}
