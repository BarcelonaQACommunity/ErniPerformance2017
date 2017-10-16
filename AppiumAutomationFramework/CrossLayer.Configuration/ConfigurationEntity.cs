using System;
using System.Xml.Serialization;

namespace CrossLayer.Configuration
{
    /// <summary>
    /// Configuration entity class.
    /// </summary>
    [Serializable]
    [XmlRootAttribute("TestConfiguration")]
    public class ConfigurationEntity
    {
        /// <summary>
        /// Gets or sets the environment.
        /// </summary>
        /// <value>
        /// The environment.
        /// </value>
        public string Environment { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is sauce labs.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is sauce labs; otherwise, <c>false</c>.
        /// </value>
        public bool IsSauceLabs { get; set; }
    }
}
