using System;

namespace ConsoleWebScraping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting web scraping...");

            var ibovespaWebScraping = new IbovespaWebScraping();
            var ibovespaInfo = ibovespaWebScraping.GetIbovespaInfo();
            var filePath = CsvHelper.SaveIbovespaInfo(ibovespaInfo);
            Console.WriteLine($"Results in {filePath}");
        }
    }
}
