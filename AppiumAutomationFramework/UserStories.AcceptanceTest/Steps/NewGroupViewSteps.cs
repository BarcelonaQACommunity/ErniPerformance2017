using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using CrossLayer.DI.Module;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pageobject.Factory.Contracts.Pages.Contracts;
using TechTalk.SpecFlow;
using UserStories.AcceptanceTest.Steps.Base;
using CrossLayer.Configuration;

namespace UserStories.AcceptanceTest.Steps
{
    /// <summary>
    /// New Group View class, contains all related steps with this view.
    /// </summary>
    /// <seealso cref="UserStories.AcceptanceTest.Steps.Base.BaseStep" />
    [Binding]
    public class NewGroupViewSteps : BaseStep
    {
        // New Group page.
        private readonly INewGroupPage _groupPage;

        /// <summary>
        /// Initializes a new instance of the <see cref="NewGroupViewSteps"/> class.
        /// </summary>
        public NewGroupViewSteps()
        {
            if (Configuration.CurrentConfiguration == Configuration.DriverConfiguration.Android)
            {
                _groupPage = AppContainer.AndroidContainer.Resolve<INewGroupPage>();
            }
            else
            {
                _groupPage = AppContainer.WebContainer.Resolve<INewGroupPage>();
            }
        }

        [Given("The user selects the group '(.*)'")]
        [When("The user selects the group '(.*)'")]
        public void TheUserSelectsTheGroup(string groupName)
        {
            _groupPage.SelectsGroup(groupName);
        }

        /// <summary>
        /// The user creates the group.
        /// </summary>
        /// <param name="groupName">Name of the group.</param>
        [When("The user creates the group '(.*)'")]
        public void TheUserCreatesTheGroup(string groupName)
        {
            _groupPage.CreatesNewGroup(groupName);
        }

        /// <summary>
        /// Thes the group is created.
        /// </summary>
        /// <param name="groupName">Name of the group.</param>
        [Then("The group '(.*)' is created")]
        public void TheGroupIsCreated(string groupName)
        {
            Assert.IsTrue(_groupPage.IsGroupCreated(groupName), $"The group {groupName} does not exist");  
        }
    }
}
