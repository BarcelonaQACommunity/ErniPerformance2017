using System.Collections.Generic;
using Factory.SetUp;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Pageobject.Appium.Factory.Base.Appium;
using Pageobject.Factory.Contracts.Pages.Contracts;

namespace Pageobject.Appium.Factory.Pages.Appium
{
    /// <summary>
    /// The android main view page.
    /// </summary>
    /// <seealso cref="Pageobject.Appium.Factory.Base.Appium.AndroidPageObjectBase" />
    /// <seealso cref="Pageobject.Factory.Contracts.Pages.Contracts.IMainViewPage" />
    public class AndroidMainViewPage : AndroidPageObjectBase, IMainViewPage
    {
        #region .: Android Elements :.

        /// <summary>
        /// Central text that appears when the app does not have any list.
        /// </summary>
        [FindsBy(How = How.Id, Using = "douzifly.list:id/txt_empty")]
        private IWebElement _proverbText;

        /// <summary>
        /// Button to go to the add task page.
        /// </summary>
        [FindsBy(How = How.Id, Using = "douzifly.list:id/fab_add")]
        private IWebElement _addTaskButton;

        /// <summary>
        /// List of tasks.
        /// </summary>
        [FindsBy(How = How.Id, Using = "douzifly.list:id/content")]
        private IList<IWebElement> _taskList;

        /// <summary>
        /// Button to go to the group list.
        /// </summary>
        [FindsBy(How = How.Id, Using = "douzifly.list:id/txt_title")]
        private IWebElement _groupButton;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidMainViewPage"/> class.
        /// </summary>
        public AndroidMainViewPage()
        {
            PageFactory.InitElements(this.AndroidDriver, this);
        }

        /// <summary>
        /// Used for the feature to set the configuration.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <exception cref="NotFoundException"></exception>
        public void SetUpWithConfiguration(string configuration)
        {
            switch (configuration)
            {
                case "Default":
                    this.SetUpDefaultConfiguration();
                    break;

                default:
                    throw new NotFoundException($"{configuration} does not exist.");
            }
        }

        /// <summary>
        /// Proverb appears when the application does not have tasks.
        /// </summary>
        public string Proverb => this._proverbText.Text;

        /// <summary>
        /// Gets the number of tasks from the list.
        /// </summary>
        public int TotalTasks => this._taskList?.Count ?? 0;

        /// <summary>
        /// Goes to the add task page.
        /// </summary>
        public void AddNewTask()
        {
            this._addTaskButton.Click();
        }

        /// <summary>
        /// Selects the task.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void SelectTask(int id)
        {
            var number = id - 1;
            this._taskList[number].Click();
        }

        /// <summary>
        /// Goes to the group list.
        /// </summary>
        public void GoToTheGroupList()
        {
            this._groupButton.Click();
        }

        /// <summary>
        /// Take the screenshot.
        /// </summary>
        /// <param name="scenarioTitle">The scenario title.</param>
        public void TakeScreenshot(string scenarioTitle)
        {
            SetUpWebDriver.MakeScreenshot(scenarioTitle);
        }

        /// <summary>
        /// Closes the android driver.
        /// </summary>
        public void CloseAndroidDriver()
        {
            SetUpWebDriver.CloseAndroidDriver();
        }
    }
}
