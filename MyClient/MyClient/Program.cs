using MyCodeLibrary;
using static System.Formats.Asn1.AsnWriter;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args) {
            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebPage("http://msdn.microsoft.com");
            Console.WriteLine(value);
        Console.ReadLine(); 
        }
    }
}
