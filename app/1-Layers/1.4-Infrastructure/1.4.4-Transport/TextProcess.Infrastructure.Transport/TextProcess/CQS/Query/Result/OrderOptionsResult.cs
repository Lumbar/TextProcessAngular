using TextProcess.Infrastructure.Transport.TextProcess.QueryEntity;

namespace TextProcess.Infrastructure.Transport.TextProcess.CQS.Query.Result
{
    public class OrderOptionsResult
    {
        public OrderOptionsQueryEntity OrderOptions { get; set; }

        public OrderOptionsResult()
        {
            OrderOptions = new OrderOptionsQueryEntity();
        }
    }
}
