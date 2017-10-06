using Autofac;
using CrossLayer.DI.Module;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pageobject.Factory.Contracts.Pages.Contracts;
using TechTalk.SpecFlow;
using UserStories.AcceptanceTest.Steps.Base;

namespace UserStories.AcceptanceTest.Steps
{
    /// <summary>
    /// Edit task view class, contains all related steps with this view.
    /// </summary>
    /// <seealso cref="UserStories.AcceptanceTest.Steps.Base.BaseStep" />
    [Binding]
    public class EditTaskViewSteps : BaseStep
    {
        // Edit task page.
        private readonly IEditTaskPage _editTaskViewPage;

        /// <summary>
        /// Initializes a new instance of the <see cref="EditTaskViewSteps"/> class.
        /// </summary>
        public EditTaskViewSteps()
        {
            this._editTaskViewPage = AppContainer.AndroidContainer.Resolve<IEditTaskPage>();
        }

        /// <summary>
        /// The user removes the task.
        /// </summary>
        [When(@"The user removes the task")]
        public void TheUserRemovesTheTask()
        {
            this._editTaskViewPage.RemoveTask();
        }

        /// <summary>
        /// The content of the task has the title and the.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="content">The content.</param>
        [Then(@"The task has the title '(.*)' and the content '(.*)'")]
        public void TheTaskHasTheTitleAndTheContent(string title, string content)
        {
            Assert.AreEqual(title, this._editTaskViewPage.Title);
            Assert.AreEqual(content, this._editTaskViewPage.Content);
        }
    }
}
