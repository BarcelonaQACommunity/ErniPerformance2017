using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossLayer.Configuration
{
    /// <summary>
    /// Transversal configuration.
    /// </summary>
    public static class Configuration
    {
        /// <summary>
        /// Gets or sets the current scenario.
        /// </summary>
        public static string CurrentScenario { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is saucelabs configuration.
        /// </summary>
        public static bool IsSaucelabsConfiguration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is pass.
        /// </summary>
        public static bool IsPass { get; set; }
    }
}
