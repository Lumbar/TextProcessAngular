using System;
using System.Net.Http;
using TextProcess.Infrastructure.Transport.TextProcess.CQS.Query.Parameter;
using TextProcess.Infrastructure.Transport.TextProcess.CQS.Query.Result;
using TextProcess.Infrastructure.Transport.TextProcess.Request;
using TextProcess.Infrastructure.Transport.TextProcess.Response;

namespace TextProcess.Infrastructure.Agent.TestProcess
{
    public class TestProcessAgent : ITestProcessAgent
    {
        private string url = "http://localhost:6804/testprocessing/api/v1/";

        public OrderedTextResult OrderedText(OrderedTextParameter parameter, string securityToken)
        {
            var request = new OrderedTextRequest { Parameters = parameter };
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            using (var httpClient = new HttpClient(clientHandler) { BaseAddress = new Uri(url) })
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Add("Authorization", securityToken);
                    httpClient.Timeout = TimeSpan.FromMinutes(30);
                    var httpResponseMessage = httpClient.PostAsJsonAsync("textProcess/OrderedText", request).Result;
                    var response = httpResponseMessage.Content.ReadAsAsync<OrderedTextResponse>().Result;
                    if (response.State.HasError)
                    {
                        throw new Exception(response.State.ErrorMessage);
                    }

                    return response.Result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public OrderOptionsResult OrderOptions(string securityToken)
        {
            string request = "";
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            using (var httpClient = new HttpClient(clientHandler) { BaseAddress = new Uri(url) })
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Add("Authorization", securityToken);
                    httpClient.Timeout = TimeSpan.FromMinutes(30);
                    var httpResponseMessage = httpClient.PostAsJsonAsync("textProcess/OrderOptions", request).Result;
                    var response = httpResponseMessage.Content.ReadAsAsync<OrderOptionsResponse>().Result;
                    if (response.State.HasError)
                    {
                        throw new Exception(response.State.ErrorMessage);
                    }

                    return response.Result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public StatisticsResult Statistics(StatisticsParameter parameter, string securityToken)
        {
            var request = new StatisticsRequest { Parameters = parameter };
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            using (var httpClient = new HttpClient(clientHandler) { BaseAddress = new Uri(url) })
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Add("Authorization", securityToken);
                    httpClient.Timeout = TimeSpan.FromMinutes(30);
                    var httpResponseMessage = httpClient.PostAsJsonAsync("textProcess/Statistics", request).Result;
                    var response = httpResponseMessage.Content.ReadAsAsync<StatisticsResponse>().Result;
                    if (response.State.HasError)
                    {
                        throw new Exception(response.State.ErrorMessage);
                    }

                    return response.Result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
