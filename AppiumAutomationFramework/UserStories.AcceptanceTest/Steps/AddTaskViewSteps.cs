using Autofac;
using CrossLayer.DI.Module;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pageobject.Factory.Contracts.Pages.Contracts;
using TechTalk.SpecFlow;
using UserStories.AcceptanceTest.Steps.Base;

namespace UserStories.AcceptanceTest.Steps
{
    /// <summary>
    /// Add task view class, contains all related steps with this view.
    /// </summary>
    /// <seealso cref="UserStories.AcceptanceTest.Steps.Base.BaseStep" />
    [Binding]
    public class AddTaskViewSteps : BaseStep
    {
        // Add Task page.
        private readonly IAddTaskPage _addTaskViewPage;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTaskViewSteps"/> class.
        /// </summary>
        public AddTaskViewSteps()
        {
            this._addTaskViewPage = AppContainer.AndroidContainer.Resolve<IAddTaskPage>();
        }

        /// <summary>
        /// The user sets the task with the title the content and the color.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="content">The content.</param>
        /// <param name="color">The color.</param>
        [When(@"The user sets the task with the title '(.*)', the content '(.*)', and the color '(.*)'")]
        public void TheUserSetsTheTaskWithTheTitleTheContentAndTheColor(string title, string content, string color)
        {
            // Title
            this._addTaskViewPage.TaskTitle = title;

            // Content
            this._addTaskViewPage.TaskContent = content;

            // Color
            this._addTaskViewPage.SetTaskColor(color);
        }

        /// <summary>
        /// The user creates the task.
        /// </summary>
        [When(@"The user creates the task")]
        public void TheUserCreatesTheTask()
        {
            this._addTaskViewPage.CreateTask();
        }

        [Given(@"The user creates a task with the title '(.*)', the content '(.*)', and the color '(.*)'")]
        [When(@"The user creates a task with the title '(.*)', the content '(.*)', and the color '(.*)'")]
        public void TheUserCreatesATaskWithTheTitleTheContentAndTheColor(string title, string content, string color)
        {
            this.When("The user goes to the add task view");
            this.When($"The user sets the task with the title '{title}', the content '{content}', and the color '{color}'");
            this.When("The user creates the task");
        }

        /// <summary>
        /// The user check that the title and the content from the task are the correct values.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="content">The content.</param>
        [Then(@"The user check that the title '(.*)' and the content '(.*)' from the task are the correct values")]
        public void TheUserCheckThatTheTitleAndTheContentFromTheTaskAreTheCorrectValues(string title, string content)
        {
            // Title
            Assert.AreEqual(title, this._addTaskViewPage.TaskTitle);

            // Content
            Assert.AreEqual(content, this._addTaskViewPage.TaskContent);
        }
    }
}
