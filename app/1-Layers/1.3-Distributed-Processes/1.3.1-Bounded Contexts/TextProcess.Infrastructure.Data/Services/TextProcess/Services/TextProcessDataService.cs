using System.Threading.Tasks;
using TextProcess.Infrastructure.Data.Contracts.TextProcess.Services;
using TextProcess.Infrastructure.Data.CQS.TextProcess.Query;
using TextProcess.Infrastructure.Transport.TextProcess.Response;

namespace TextProcess.Infrastructure.Data.Services.TextProcess.Services
{
    public class TextProcessDataService : ITextProcessDataService
    {
        private readonly ITextProcessQuery _textProcessQuery;

        public TextProcessDataService(ITextProcessQuery textProcessQuery)
        {
            _textProcessQuery = textProcessQuery;
        }

        public Task<OrderOptionsResponse> OrderOptions()
        {
            OrderOptionsResponse response = new OrderOptionsResponse
            {
                Result = _textProcessQuery.OrderOptions()
            };

            return Task.FromResult(response);
        }
    }
}
