using System.Configuration;

namespace SikhUnit.Configuration
{
    public class SiteConfiguration
    {
        public static string ContentPath { get { return ConfigurationManager.AppSettings["ContentPath"]; } }
        public static string AlbumsPath { get { return ConfigurationManager.AppSettings["AlbumsPath"]; } }
        public static string LiteraturesPath { get { return ConfigurationManager.AppSettings["LiteraturesPath"]; } }
        public static string BaseUrl { get { return ConfigurationManager.AppSettings["BaseUrl"]; } }
        public static int DurationMinutes { get { return int.Parse(ConfigurationManager.AppSettings["DurationMinutes"]); } }
        public static int AlbumPageSize { get { return int.Parse(ConfigurationManager.AppSettings["AlbumPageSize"]); } }
        public static string EmailSubject { get { return ConfigurationManager.AppSettings["EmailSubject"]; } }
        public static string ContactUsToEmailAddress { get { return ConfigurationManager.AppSettings["ContactUsToEmailAddress"]; } }
    }
}