using OpenQA.Selenium;
using Pageobject.Factory.Contracts.Base.Contracts;

namespace Pageobject.Factory.Contracts.Pages.Contracts
{
    /// <summary>
    /// The Add Task interface.
    /// </summary>
    /// <seealso cref="Pageobject.Factory.Contracts.Base.Contracts.IPageObjectBase" />
    public interface IAddTaskPage : IPageObjectBase
    {
        /// <summary>
        /// Gets or sets the task title.
        /// </summary>
        string TaskTitle { get; set; }

        /// <summary>
        /// Gets or sets the content of the task.
        /// </summary>
        string TaskContent { get; set; }

        /// <summary>
        /// Sets the color of the task.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetTaskColor(string color);

        /// <summary>
        /// Creates the task.
        /// </summary>
        void CreateTask();
    }
}
