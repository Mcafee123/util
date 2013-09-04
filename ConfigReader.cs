using System;
using System.Configuration;
using Winforms.Base.Core.Interfaces.Config;

namespace Winforms.Base.Core.Config
{
    public class ConfigReader : IConfigReader
    {
        public string GetConnectionString(string key, string defaultValue)
        {
            var val = ConfigurationManager.ConnectionStrings[key].ConnectionString;
            return String.IsNullOrEmpty(val) ? defaultValue : val;
        }

        public string GetString(string key, string defaultValue)
        {
            var val = ConfigurationManager.AppSettings[key];
            return String.IsNullOrEmpty(val) ? defaultValue : val;
        }

        public int GetInt(string key, int defaultValue)
        {
            var s = GetString(key, null);
            int result;
            if (!String.IsNullOrEmpty(s) && Int32.TryParse(s, out result))
            {
                return result;
            }
            return defaultValue;
        }

        public bool GetBool(string key, bool defaultValue)
        {
            var s = GetString(key, null);
            bool result;
            if (!String.IsNullOrEmpty(s) && Boolean.TryParse(s, out result))
            {
                return result;
            }
            return defaultValue;
        }
    }
}