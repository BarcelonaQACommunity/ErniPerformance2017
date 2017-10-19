using Factory.SetUp;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Pageobject.Factory.Contracts.Pages.Contracts;
using Pageobject.Web.Factory.Base.Web;

namespace Pageobject.Web.Factory
{
    /// <summary>
    /// The web add task page class.
    /// </summary>
    /// <seealso cref="Pageobject.Web.Factory.Base.Web.WebPageObjectBase" />
    /// <seealso cref="Pageobject.Factory.Contracts.Pages.Contracts.IAddTaskPage" />
    public class WebAddTaskPage : WebPageObjectBase, IAddTaskPage
    {
        #region .: Web Elements :.

        [FindsBy(How = How.Id, Using = "textBox-itemTitle")]
        private IWebElement _taskTitleTextBox;

        [FindsBy(How = How.Id, Using = "textBox-itemDescription")]
        private IWebElement _taskDescriptionTextBox;

        [FindsBy(How = How.Id, Using = "button-addItem")]
        private IWebElement _taskNewItemButton;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="WebAddTaskPage"/> class.
        /// </summary>
        /// <param name="setUpWebDriver">The set up web driver.</param>
        public WebAddTaskPage(ISetUpWebDriver setUpWebDriver) 
            : base(setUpWebDriver)
        {
            PageFactory.InitElements(WebDriver, this);
        }

        /// <summary>
        /// Gets or sets the task title.
        /// </summary>
        public string TaskTitle
        {
            get { return _taskTitleTextBox.GetAttribute("value"); }
            set { _taskTitleTextBox.SendKeys(value); }
        }

        /// <summary>
        /// Gets or sets the content of the task.
        /// </summary>
        public string TaskContent
        {
            get { return _taskDescriptionTextBox.GetAttribute("value"); }
            set { _taskDescriptionTextBox.SendKeys(value); }
        }

        /// <summary>
        /// Creates the task.
        /// </summary>
        public void CreateTask()
        {
            _taskNewItemButton.Click();
        }

        /// <summary>
        /// Sets the color of the task.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetTaskColor(string color)
        {
            //TODO Add color
        }
    }
}
