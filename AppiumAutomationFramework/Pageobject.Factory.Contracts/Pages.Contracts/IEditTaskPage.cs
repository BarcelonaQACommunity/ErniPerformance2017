using Pageobject.Factory.Contracts.Base.Contracts;

namespace Pageobject.Factory.Contracts.Pages.Contracts
{
    /// <summary>
    /// Edit task page interface.
    /// </summary>
    /// <seealso cref="Pageobject.Factory.Contracts.Base.Contracts.IPageObjectBase" />
    public interface IEditTaskPage : IPageObjectBase
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        string Content { get; set; }

        /// <summary>
        /// Removes the task.
        /// </summary>
        void RemoveTask();
    }
}
