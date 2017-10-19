using Autofac;
using CrossLayer.DI.Module;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pageobject.Factory.Contracts.Pages.Contracts;
using TechTalk.SpecFlow;
using UserStories.AcceptanceTest.Steps.Base;

namespace UserStories.AcceptanceTest.Steps
{
    /// <summary>
    /// New Group View class, contains all related steps with this view.
    /// </summary>
    /// <seealso cref="UserStories.AcceptanceTest.Steps.Base.BaseStep" />
    /// 
    //EXERCISES:
    //1 - Implement the gerkin expressions to select, create and check for the groups (In the interface INewGroupPage, the methods are defined).
    //2 - Create an Assert that checks if the group has no name and the "The NewGroup field is required." was triggered.
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
            _groupPage = AppContainer.Container.Resolve<INewGroupPage>();
        }
        
        //TODO: Exercise 1 + 2
    }
}
