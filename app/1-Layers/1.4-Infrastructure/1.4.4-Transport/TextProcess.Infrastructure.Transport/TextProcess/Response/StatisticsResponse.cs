using TextProcess.Infrastructure.Transport.Core.Response;
using TextProcess.Infrastructure.Transport.TextProcess.CQS.Query.Result;

namespace TextProcess.Infrastructure.Transport.TextProcess.Response
{
    public class StatisticsResponse : BaseResponse
    {
        public StatisticsResult Result { get; set; }

        public StatisticsResponse()
        {
            Result = new StatisticsResult();
        }
    }
}
