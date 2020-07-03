using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Web;

namespace e_shastho.Helpers
{
    public class ApplicationConfig
    {
        public static string BaseUrl
        {
            get
            {
                string baseUrl = "";
                if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["BaseUrl"]))
                    baseUrl = Convert.ToString(ConfigurationManager.AppSettings["BaseUrl"]);
                return baseUrl;
            }
        }
    }
}