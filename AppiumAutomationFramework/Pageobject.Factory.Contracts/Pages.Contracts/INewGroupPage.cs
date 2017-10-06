using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pageobject.Factory.Contracts.Base.Contracts;

namespace Pageobject.Factory.Contracts.Pages.Contracts
{
    /// <summary>
    /// New Group Page interface.
    /// </summary>
    /// <seealso cref="Pageobject.Factory.Contracts.Base.Contracts.IPageObjectBase" />
    public interface INewGroupPage : IPageObjectBase
    {
        /// <summary>
        /// Creates the new group.
        /// </summary>
        /// <param name="groupName">Name of the group.</param>
        void CreatesNewGroup(string groupName);

        /// <summary>
        /// Check group by name.
        /// </summary>
        /// <param name="groupName">Name of the group.</param>
        bool IsGroupCreated(string groupName);

        /// <summary>
        /// Selectses the group.
        /// </summary>
        /// <param name="groupName">Name of the group.</param>
        void SelectsGroup(string groupName);
    }
}
