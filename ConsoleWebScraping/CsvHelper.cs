using ConsoleWebScraping.DTOs;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.IO;

namespace ConsoleWebScraping
{
    public class CsvHelper
    {
        public static string SaveIbovespaInfo(IbovespaInfoDTO ibovespaInfoDTO)
        {
            string folderName = "results";
            string fileName = "ibovespaInfo.csv";
            var filePath = $"{folderName}\\{fileName}";
            if(File.Exists(fileName) is false)
            {
                Directory.CreateDirectory(folderName);
                File.Create(filePath).Dispose();
            }
            using(var writer = new StreamWriter(filePath))
            using(var csv = new CsvWriter(writer, 
                new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" }))
            {
                csv.WriteHeader<IbovespaInfoDTO>();
                csv.NextRecord();
                csv.WriteRecord(ibovespaInfoDTO);
            }

            return Path.GetFullPath(filePath);
        }
    }
}
