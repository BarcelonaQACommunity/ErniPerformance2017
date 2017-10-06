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
    /// Android new group page.
    /// </summary>
    /// <seealso cref="Pageobject.Appium.Factory.Base.Appium.AndroidPageObjectBase" />
    /// <seealso cref="Pageobject.Factory.Contracts.Pages.Contracts.INewGroupPage" />
    public class AndroidNewGroupPage : AndroidPageObjectBase, INewGroupPage
    {
        #region .: Android Elements :.

        /// <summary>
        /// The group list.
        /// </summary>
        [FindsBy(How = How.Id, Using = "douzifly.list:id/txt_title")]
        private IList<IWebElement> _groupList;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidNewGroupPage"/> class.
        /// </summary>
        public AndroidNewGroupPage()
        {
            PageFactory.InitElements(this.AndroidDriver, this);
        }

        /// <summary>
        /// Creates the new group.
        /// </summary>
        /// <param name="groupName">Name of the group.</param>
        public void CreatesNewGroup(string groupName)
        {
            // Add button
            // TODO - Add button

            // Add name
            // TODO - Add name

            // Creates the group
            // TODO - Confirms the name
        }

        /// <summary>
        /// Check group by name.
        /// </summary>
        /// <param name="groupName">Name of the group.</param>
        public bool IsGroupCreated(string groupName)
        {
            return _groupList.Any(g => g.Text == groupName);
        }

        /// <summary>
        /// Selectses the group.
        /// </summary>
        /// <param name="groupName">Name of the group.</param>
        public void SelectsGroup(string groupName)
        {
            _groupList.First(g => g.Text == groupName).Click();
        }
    }
}
