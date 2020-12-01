using TextProcess.Infrastructure.Transport.TextProcess.CQS.Query.Result;

namespace TextProcess.Infrastructure.Data.CQS.TextProcess.Query
{
    public interface ITextProcessQuery
    {
        OrderOptionsResult OrderOptions();
    }
}
