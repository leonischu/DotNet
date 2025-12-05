using System;
using System.Net;

namespace MyCodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebPage(string url)
        {
            return GetWebpage(url);

        }
        public string ScrapeWebpage(string url, string filepath)
        {
            string reply = GetWebpage(url);
            File.WriteAllText(filepath, reply);
            return reply;
        }


        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}