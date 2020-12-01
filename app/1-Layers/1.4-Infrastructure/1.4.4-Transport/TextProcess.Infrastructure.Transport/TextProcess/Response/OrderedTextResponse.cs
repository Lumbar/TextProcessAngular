using TextProcess.Infrastructure.Transport.Core.Response;
using TextProcess.Infrastructure.Transport.TextProcess.CQS.Query.Result;

namespace TextProcess.Infrastructure.Transport.TextProcess.Response
{
    public class OrderedTextResponse : BaseResponse
    {
        public OrderedTextResult Result { get; set; }

        public OrderedTextResponse()
        {
            Result = new OrderedTextResult();
        }
    }
}
