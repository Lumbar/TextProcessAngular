using System.Threading.Tasks;
using TextProcess.Infrastructure.Transport.TextProcess.Response;

namespace TextProcess.Infrastructure.Data.Contracts.TextProcess.Services
{
    public interface ITextProcessDataService
    {
        Task<OrderOptionsResponse> OrderOptions();
    }
}
