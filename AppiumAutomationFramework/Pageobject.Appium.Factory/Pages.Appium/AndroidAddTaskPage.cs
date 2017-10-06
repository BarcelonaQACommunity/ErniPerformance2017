using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Pageobject.Appium.Factory.Base.Appium;
using Pageobject.Factory.Contracts.Pages.Contracts;

namespace Pageobject.Appium.Factory.Pages.Appium
{
    /// <summary>
    /// The android add task page.
    /// </summary>
    /// <seealso cref="Pageobject.Appium.Factory.Base.Appium.AndroidPageObjectBase" />
    /// <seealso cref="Pageobject.Factory.Contracts.Pages.Contracts.IAddTaskPage" />
    public class AndroidAddTaskPage  : AndroidPageObjectBase, IAddTaskPage
    {
        #region .: Android Elements :.

        /// <summary>
        /// The title task.
        /// </summary>
        [FindsBy(How = How.Id, Using = "douzifly.list:id/edit_text")]
        private IWebElement _titleTask;

        /// <summary>
        /// The content task.
        /// </summary>
        [FindsBy(How = How.Id, Using = "douzifly.list:id/edit_text_content")]
        private IWebElement _contentTask;

        /// <summary>
        /// The color picker.
        /// Colors are inside with the <android.view.View/> tag.
        /// </summary>
        [FindsBy(How = How.ClassName, Using = "android.view.View")]
        private IList<IWebElement> _colorPicker;

        /// <summary>
        /// The create task button.
        /// </summary>
        [FindsBy(How = How.Id, Using = "douzifly.list:id/fab_add")]
        private IWebElement _createTaskButton;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidAddTaskPage"/> class.
        /// </summary>
        public AndroidAddTaskPage()
        {
            PageFactory.InitElements(this.AndroidDriver, this);
        }

        /// <summary>
        /// Gets or sets the task title.
        /// </summary>
        public string TaskTitle
        {
            get { return this._titleTask.Text; }
            set { this._titleTask.SendKeys(value);}
        }

        /// <summary>
        /// Gets or sets the content of the task.
        /// </summary>
        public string TaskContent
        {
            get { return this._contentTask.Text; }
            set { this._contentTask.SendKeys(value);}
        }

        /// <summary>
        /// Sets the color of the task.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <exception cref="NotFoundException"></exception>
        public void SetTaskColor(string color)
        {
            switch (color)
            {
                case "Blue":
                    this._colorPicker[0].Click();
                    break;

                case "Red":
                    this._colorPicker[1].Click();
                    break;

                case "Yellow":
                    this._colorPicker[2].Click();
                    break;

                case "Green":
                    this._colorPicker[3].Click();
                    break;

                case "Pink":
                    this._colorPicker[4].Click();
                    break;

                case "Grey":
                    this._colorPicker[5].Click();
                    break;

                case "Brown":
                    this._colorPicker[6].Click();
                    break;

                case "White":
                    this._colorPicker[7].Click();
                    break;

                default:
                    throw new NotFoundException($"{color} not found");
            }
        }

        /// <summary>
        /// Creates the task.
        /// </summary>
        public void CreateTask()
        {
            this._createTaskButton.Click();
        }
    }
}
