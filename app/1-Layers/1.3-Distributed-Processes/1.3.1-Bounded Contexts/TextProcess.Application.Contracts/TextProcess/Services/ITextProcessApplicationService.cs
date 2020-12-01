using System.Threading.Tasks;
using TextProcess.Infrastructure.Transport.TextProcess.Request;
using TextProcess.Infrastructure.Transport.TextProcess.Response;

namespace TextProcess.Application.Contracts.TextProcess.Services
{
    public interface ITextProcessApplicationService
    {
        Task<OrderOptionsResponse> OrderOptions();
        Task<OrderedTextResponse> OrderedText(OrderedTextRequest request);
        Task<StatisticsResponse> Statistics(StatisticsRequest request);
    }
}
