using Pageobject.Factory.Contracts.Pages.Contracts;
using Pageobject.Web.Factory.Base.Web;
using System;
using Factory.SetUp;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace Pageobject.Web.Factory
{
    /// <summary>
    /// The main view page.
    /// </summary>
    /// <seealso cref="Pageobject.Web.Factory.Base.Web.WebPageObjectBase" />
    /// <seealso cref="Pageobject.Factory.Contracts.Pages.Contracts.IMainViewPage" />
    public class WebMainViewPage : WebPageObjectBase, IMainViewPage
    {
        #region .: Web Elements :.

        [FindsBy(How = How.TagName, Using = "label")]
        private IWebElement _erniPhrase;

        [FindsBy(How = How.ClassName, Using = "well")]
        private IList<IWebElement> _taskList;

        [FindsBy(How = How.XPath, Using = "//p/a")]
        private IWebElement _addTask;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="WebMainViewPage"/> class.
        /// </summary>
        /// <param name="setUpWebDriver">The set up web driver.</param>
        public WebMainViewPage(ISetUpWebDriver setUpWebDriver) 
            : base(setUpWebDriver)
        {
            PageFactory.InitElements(WebDriver, this);
        }

        /// <summary>
        /// Proverb appears when the application does not have tasks.
        /// </summary>
        public string Proverb => _erniPhrase.Text;

        /// <summary>
        /// Gets the number of tasks from the list.
        /// </summary>
        public int TotalTasks => _taskList.Count - 1;

        /// <summary>
        /// Goes to the add task page.
        /// </summary>
        public void AddNewTask()
        {
            _addTask.Click();
        }

        /// <summary>
        /// Goes to the group list.
        /// </summary>
        public void GoToTheGroupList()
        {
            // Its not necessary.
        }

        /// <summary>
        /// Selects the task.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void SelectTask(int id)
        {
            WebDriver.FindElement(By.XPath($"//div[@id='item-{id}']/div/a[1]")).Click();
        }

        /// <summary>
        /// Closes the android driver.
        /// </summary>
        public void CloseDriver()
        {
            SetUpWebDriverFactory.CloseWebDriver();
        }

        /// <summary>
        /// Takes the screenshot.
        /// </summary>
        /// <param name="scenarioTitle">The scenario title.</param>
        public void TakeScreenshot(string scenarioTitle)
        {
            SetUpWebDriverFactory.MakeWebScreenshot(scenarioTitle);
        }
    }
}
