using TextProcess.Infrastructure.Transport.TextProcess.QueryEntity;

namespace TextProcess.Infrastructure.Transport.TextProcess.CQS.Query.Result
{
    public class StatisticsResult
    {
        public StatisticsQueryEntity TextStatistics { get; set; }

        public StatisticsResult()
        {
            TextStatistics = new StatisticsQueryEntity();
        }
    }
}
