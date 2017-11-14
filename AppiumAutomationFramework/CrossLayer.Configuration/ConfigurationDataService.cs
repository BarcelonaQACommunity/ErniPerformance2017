using System.IO;
using System.Xml.Serialization;

namespace CrossLayer.Configuration
{
    using System;

    /// <summary>
    /// Transversal configuration.
    /// </summary>
    public static class ConfigurationDataService
    {
        private const string XmlFileConfigurationPath = @"\..\CrossLayer.Configuration\configuration\TestConfiguration.xml";

        /// <summary>
        /// Initializes the <see cref="ConfigurationDataService"/> class.
        /// </summary>
        static ConfigurationDataService()
        {
            GetConfigurationFromXml();
        }

        /// <summary>
        /// Gets the configuration entity.
        /// </summary>
        /// <value>
        /// The configuration entity.
        /// </value>
        public static ConfigurationEntity Configuration { get; private set; }

        /// <summary>
        /// Gets or sets the current scenario.
        /// </summary>
        public static string CurrentScenario { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is pass.
        /// </summary>
        public static bool IsPass { get; set; }

        private static void GetConfigurationFromXml()
        {
            try
            {
                var serializer = new XmlSerializer(typeof(ConfigurationEntity));
                using (var stream = new FileStream(Directory.GetCurrentDirectory() + XmlFileConfigurationPath, FileMode.Open))
                {
                    Configuration = (ConfigurationEntity)serializer.Deserialize(stream);
                }
            }
            catch (Exception)
            {
                GetConfigurationFromXml();
            }
        }
    }
}
