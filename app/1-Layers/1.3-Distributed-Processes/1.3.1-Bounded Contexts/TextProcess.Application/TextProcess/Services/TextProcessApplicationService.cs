using System.Threading.Tasks;
using TextProcess.Application.Contracts.TextProcess.Services;
using TextProcess.Domain.Contracts.TextProcess.Services;
using TextProcess.Infrastructure.Data.Contracts.TextProcess.Services;
using TextProcess.Infrastructure.Transport.TextProcess.Request;
using TextProcess.Infrastructure.Transport.TextProcess.Response;

namespace TextProcess.Application.TextProcess.Services
{
    public class TextProcessApplicationService : ITextProcessApplicationService
    {
        private ITextProcessDataService _textProcessDataService;
        private ITextProcessDomainService _textProcessDomainService;

        public TextProcessApplicationService(ITextProcessDataService textProcessDataService,
            ITextProcessDomainService textProcessDomainService)
        {
            _textProcessDataService = textProcessDataService;
            _textProcessDomainService = textProcessDomainService;
        }

        public Task<OrderedTextResponse> OrderedText(OrderedTextRequest request)
        {
            return _textProcessDomainService.OrderedText(request);
        }

        public Task<OrderOptionsResponse> OrderOptions()
        {
            return _textProcessDataService.OrderOptions();
        }

        public Task<StatisticsResponse> Statistics(StatisticsRequest request)
        {
            return _textProcessDomainService.Statistics(request);
        }
    }
}
