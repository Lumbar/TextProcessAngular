using TextProcess.Infrastructure.Transport.TextProcess.CQS.Query.Parameter;
using TextProcess.Infrastructure.Transport.TextProcess.CQS.Query.Result;

namespace TextProcess.Infrastructure.Agent.TestProcess
{
    public interface ITestProcessAgent
    {
        OrderOptionsResult OrderOptions(string securityToken);
        OrderedTextResult OrderedText(OrderedTextParameter parameter, string securityToken);
        StatisticsResult Statistics(StatisticsParameter parameter, string securityToken);
    }
}
