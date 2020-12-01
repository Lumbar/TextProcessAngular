namespace TextProcess.API.Controllers
{
    using System.IO;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using TextProcess.Application.Contracts.TextProcess.Services;
    using TextProcess.Infrastructure.Transport.TextProcess.Request;
    using TextProcess.Infrastructure.Transport.TextProcess.Response;
    using TextProcess.Infrastructure.Web.API;

    public class TextProcessController : BaseController
    {
        private readonly ITextProcessApplicationService _textProcessApplicationService;

        public TextProcessController(ITextProcessApplicationService textProcessApplicationService)
        {
            _textProcessApplicationService = textProcessApplicationService;
        }

        [HttpPost]
        public async Task<OrderOptionsResponse> OrderOptions()
        {
            return await _textProcessApplicationService.OrderOptions();
        }

        [HttpPost]
        public async Task<OrderedTextResponse> OrderedText(OrderedTextRequest request)
        {
            return await _textProcessApplicationService.OrderedText(request);
        }

        [HttpPost]
        public async Task<StatisticsResponse> Statistics(StatisticsRequest request)
        {
            return await _textProcessApplicationService.Statistics(request);
        }
    }
}
