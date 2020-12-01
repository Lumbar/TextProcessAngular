using TextProcess.Infrastructure.Transport.TextProcess.QueryEntity;

namespace TextProcess.Infrastructure.Transport.TextProcess.CQS.Query.Result
{
    public class OrderedTextResult
    {
        public OrderedTextQueryEntity OrderedText { get; set; }

        public OrderedTextResult()
        {
            OrderedText = new OrderedTextQueryEntity();
        }
    }
}
