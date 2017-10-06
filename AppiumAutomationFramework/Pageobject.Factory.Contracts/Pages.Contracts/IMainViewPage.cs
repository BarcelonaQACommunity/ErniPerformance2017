using Pageobject.Factory.Contracts.Base.Contracts;

namespace Pageobject.Factory.Contracts.Pages.Contracts
{
    /// <summary>
    /// The main view interface.
    /// </summary>
    /// <seealso cref="Pageobject.Factory.Contracts.Base.Contracts.IPageObjectBase" />
    public interface IMainViewPage : IPageObjectBase
    {
        /// <summary>
        /// Used for the feature to set the configuration.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        void SetUpWithConfiguration(string configuration);

        /// <summary>
        /// Proverb appears when the application does not have tasks.
        /// </summary>
        string Proverb { get; }

        /// <summary>
        /// Gets the number of tasks from the list.
        /// </summary>
        int TotalTasks { get; }

        /// <summary>
        /// Goes to the add task page.
        /// </summary>
        void AddNewTask();

        /// <summary>
        /// Selects the task.
        /// </summary>
        /// <param name="id">The identifier.</param>
        void SelectTask(int id);

        /// <summary>
        /// Takes the screenshot.
        /// </summary>
        /// <param name="scenarioTitle">The scenario title.</param>
        void TakeScreenshot(string scenarioTitle);

        /// <summary>
        /// Closes the android driver.
        /// </summary>
        void CloseAndroidDriver();

        /// <summary>
        /// Goes to the group list.
        /// </summary>
        void GoToTheGroupList();
    }
}
