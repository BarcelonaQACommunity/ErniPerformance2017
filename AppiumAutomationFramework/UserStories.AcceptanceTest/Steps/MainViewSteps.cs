using Autofac;
using CrossLayer.Configuration;
using CrossLayer.DI.Module;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pageobject.Factory.Contracts.Pages.Contracts;
using TechTalk.SpecFlow;
using TechTalk.SpecRun.Helper;
using UserStories.AcceptanceTest.Steps.Base;

namespace UserStories.AcceptanceTest.Steps
{
    /// <summary>
    /// Main View class, contains all related steps with this view.
    /// </summary>
    /// <seealso cref="UserStories.AcceptanceTest.Steps.Base.BaseStep" />
    [Binding]
    public class MainViewSteps : BaseStep
    {
        // Main View page.
        private IMainViewPage _mainViewPage;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewSteps"/> class.
        /// </summary>
        public MainViewSteps()
        {
            ConfigurationDataService.CurrentScenario = ScenarioContext.Current.ScenarioInfo.Title;
            _mainViewPage = AppContainer.Container.Resolve<IMainViewPage>();
        }

        /// <summary>
        /// The user goes to the add task view.
        /// </summary>
        [Given(@"The user goes to the add task view")]
        [When(@"The user goes to the add task view")]
        public void TheUserGoesToTheAddTaskView()
        {
            _mainViewPage.AddNewTask();
        }

        /// <summary>
        /// Check that the list does not have tasks.
        /// </summary>
        [Given(@"The application does not have any tasks")]
        [When(@"The application does not have any tasks")]
        public void TheApplicationDoesNotHaveAnyTasks()
        {
            Assert.AreEqual(0, _mainViewPage.TotalTasks);
        }

        /// <summary>
        /// User goes to the task edit view.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [When(@"The user goes to the task '(.*)' edit view")]
        public void TheUserGoesToTheTaskEditView(int id)
        {
            _mainViewPage.SelectTask(id);
        }

        /// <summary>
        /// User goes to the group list.
        /// </summary>
        [When(@"The user goes to the group list")]
        public void TheUserGoesToTheGroupList()
        {
            _mainViewPage.GoToTheGroupList();
        }

        /// <summary>
        /// Check that the user sees a proverb.
        /// </summary>
        [Then(@"The user sees a proverb")]
        public void TheUserSeesAProverb()
        {
            Assert.IsFalse(_mainViewPage.Proverb.IsNullOrEmpty());
        }

        /// <summary>
        /// The application have task created.
        /// </summary>
        /// <param name="total">The total.</param>
        [Then(@"The application has '(.*)' task created")]
        public void TheApplicationHaveTaskCreated(int total)
        {
            Assert.AreEqual(total, _mainViewPage.TotalTasks);
        }

        /// <summary>
        /// Afters the scenario.
        /// </summary>
        [AfterScenario]
        public void AfterScenario()
        {
            // Set the result in the saucelabs dashboard.
            ConfigurationDataService.IsPass = true;

            if (ScenarioContext.Current.TestError != null)
            {
                ConfigurationDataService.IsPass = false;

                // Take a screenshot if the test fails.
                _mainViewPage.TakeScreenshot(ScenarioContext.Current.ScenarioInfo.Title);
            }

            _mainViewPage.CloseDriver();
        }
    }
}
