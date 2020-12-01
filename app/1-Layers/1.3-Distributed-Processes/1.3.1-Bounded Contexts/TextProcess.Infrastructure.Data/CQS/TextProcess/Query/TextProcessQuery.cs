using System.Collections.Generic;
using TextProcess.Infrastructure.Transport.TextProcess.CQS.Query.Result;

namespace TextProcess.Infrastructure.Data.CQS.TextProcess.Query
{
    public class TextProcessQuery : ITextProcessQuery
    {
        public OrderOptionsResult OrderOptions()
        {
            List<string> options = new List<string>();
            options.Add("AlphabeticAsc");
            options.Add("AlphabeticDesc");
            options.Add("LenghtAsc");
            
            OrderOptionsResult result = new OrderOptionsResult();
            result.OrderOptions.Options = options;

            return result;
        }
    }
}
