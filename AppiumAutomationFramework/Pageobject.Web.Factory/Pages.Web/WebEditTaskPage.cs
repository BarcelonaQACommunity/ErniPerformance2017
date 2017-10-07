using Factory.SetUp;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Pageobject.Factory.Contracts.Pages.Contracts;
using Pageobject.Web.Factory.Base.Web;

namespace Pageobject.Web.Factory
{
    public class WebEditTaskPage : WebPageObjectBase, IEditTaskPage
    {
        #region .: Web Elements :.

        [FindsBy(How = How.Id, Using = "textBox-itemTitle")]
        private IWebElement _taskTitleTextBox;

        [FindsBy(How = How.Id, Using = "textBox-itemDescription")]
        private IWebElement _taskDescriptionTextBox;

        [FindsBy(How = How.Id, Using = "button-addItem")]
        private IWebElement _taskNewItemButton;

        [FindsBy(How = How.Id, Using = "dropDown-itemColor")]
        private IWebElement _colorDropDownMenu;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="WebEditTaskPage"/> class.
        /// </summary>
        /// <param name="setUpWebDriver">The set up web driver.</param>
        public WebEditTaskPage(ISetUpWebDriver setUpWebDriver) 
            : base(setUpWebDriver)
        {
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title
        {
            get { return _taskTitleTextBox.GetAttribute("value"); }
            set { _taskTitleTextBox.SendKeys(value); }
        }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        public string Content
        {
            get { return _taskDescriptionTextBox.GetAttribute("value"); }
            set { _taskDescriptionTextBox.SendKeys(value); }
        }

        /// <summary>
        /// Removes the task.
        /// </summary>
        public void RemoveTask()
        {
            // TODO
        }
    }
}
