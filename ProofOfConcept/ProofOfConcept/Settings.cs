using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ProofOfConcept
{
    class Settings
    {
        public string BaseUrl { get; private set; }
        public string BrowserName { get; private set; }
        public string BrowserPath { get; set; }

        
        private static Settings settings;
        public static Settings CurrentSettings
        {
            get
            {
                if (settings == null)
                {
                    LoadSettings("TestRun.config");
                }
                return settings;
            }
        }

        private Settings(string url)
        {
            BaseUrl = url;
        }

        private static void LoadSettings(String file)
        {
            XElement settingsFile = XElement.Load(file);
            string URL = settingsFile.Element("URL").Value;
            settings = new Settings(URL);

            string BrowserName = settingsFile.Element("BROWSER").Value;
            settings.BrowserName = BrowserName;

            string BrowserPath = settingsFile.Element("BrowserPath").Value;
            settings.BrowserPath = BrowserPath;
        }
    }
}
