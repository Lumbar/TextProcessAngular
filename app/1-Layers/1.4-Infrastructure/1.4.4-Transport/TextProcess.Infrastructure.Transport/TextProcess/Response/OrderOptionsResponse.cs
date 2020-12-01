using TextProcess.Infrastructure.Transport.Core.Response;
using TextProcess.Infrastructure.Transport.TextProcess.CQS.Query.Result;

namespace TextProcess.Infrastructure.Transport.TextProcess.Response
{
    public class OrderOptionsResponse : BaseResponse
    {
        public OrderOptionsResult Result { get; set; }

        public OrderOptionsResponse()
        {
            Result = new OrderOptionsResult();
        }
    }
}
