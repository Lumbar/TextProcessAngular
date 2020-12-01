using System.Threading.Tasks;
using TextProcess.Infrastructure.Transport.TextProcess.Request;
using TextProcess.Infrastructure.Transport.TextProcess.Response;

namespace TextProcess.Domain.Contracts.TextProcess.Services
{
    public interface ITextProcessDomainService
    {
        Task<OrderedTextResponse> OrderedText(OrderedTextRequest request);
        Task<StatisticsResponse> Statistics(StatisticsRequest request);
    }
}
