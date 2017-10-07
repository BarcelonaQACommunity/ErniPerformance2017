using Factory.SetUp;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Pageobject.Appium.Factory.Base.Appium;
using Pageobject.Factory.Contracts.Pages.Contracts;

namespace Pageobject.Appium.Factory.Pages.Appium
{
    /// <summary>
    /// The android edit task page.
    /// </summary>
    /// <seealso cref="Pageobject.Appium.Factory.Base.Appium.AndroidPageObjectBase" />
    /// <seealso cref="Pageobject.Factory.Contracts.Pages.Contracts.IEditTaskPage" />
    public class AndroidEditTaskPage : AndroidPageObjectBase, IEditTaskPage
    {
        #region .: Android Elements :.

        /// <summary>
        /// The task title.
        /// </summary>
        [FindsBy(How = How.Id, Using = "douzifly.list:id/txt_title")]
        private IWebElement _taskTitle;

        /// <summary>
        /// The task content.
        /// </summary>
        [FindsBy(How = How.Id, Using = "douzifly.list:id/txt_content")]
        private IWebElement _taskContent;

        /// <summary>
        /// Button to remove the task.
        /// </summary>
        [FindsBy(How = How.Id, Using = "douzifly.list:id/action_delete")]
        private IWebElement _removeButton;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidEditTaskPage"/> class.
        /// </summary>
        public AndroidEditTaskPage(ISetUpWebDriver setUpWebDriver)
            : base(setUpWebDriver)
        {
            PageFactory.InitElements(AndroidDriver, this);
        }

        /// <summary>
        /// Gets or sets the title of the task.
        /// </summary>
        public string Title
        {
            get { return _taskTitle.Text; }
            set { _taskTitle.SendKeys(value); }
        }

        /// <summary>
        /// Gets or sets the content of the task.
        /// </summary>
        public string Content
        {
            get { return _taskContent.Text; }
            set { _taskContent.SendKeys(value); }
        }

        /// <summary>
        /// Removes the task.
        /// </summary>
        public void RemoveTask()
        {
            _removeButton.Click();
        }
    }
}
