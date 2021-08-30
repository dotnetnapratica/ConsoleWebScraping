
namespace ConsoleWebScraping.DTOs
{
    public class IbovespaInfoDTO
    {
        public IbovespaInfoDTO()
        {
        }

        public IbovespaInfoDTO(int totalPoints, string percentageVariation)
        {
            TotalPoints = totalPoints;
            PercentageVariation = percentageVariation;
        }

        public int TotalPoints { get; set; }

        public string PercentageVariation { get; set; }
    }
}
