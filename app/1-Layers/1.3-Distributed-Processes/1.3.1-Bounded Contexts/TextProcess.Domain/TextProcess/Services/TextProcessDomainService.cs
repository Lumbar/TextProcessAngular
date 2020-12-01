using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TextProcess.Domain.Contracts.TextProcess.Services;
using TextProcess.Infrastructure.Transport.TextProcess.Request;
using TextProcess.Infrastructure.Transport.TextProcess.Response;
using System.Linq;
using System.Text.RegularExpressions;

namespace TextProcess.Domain.TextProcess.Services
{
    public class TextProcessDomainService : ITextProcessDomainService
    {
        public Task<OrderedTextResponse> OrderedText(OrderedTextRequest request)
        {
            OrderedTextResponse response = new OrderedTextResponse();

            List<string> text = request.Parameters.TextToOrder.Split(" ").ToList();

            switch (request.Parameters.OrderOption)
            {
                case "AlphabeticAsc":
                    response.Result.OrderedText.OrderedWords = text.OrderBy(q => q).ToList();
                    break;
                case "AlphabeticDesc":
                    response.Result.OrderedText.OrderedWords = text.OrderByDescending(q => q).ToList();
                    break;
                case "LenghtAsc":
                    var resultText = from s in text
                                 orderby s.Length ascending
                                 select s;

                    response.Result.OrderedText.OrderedWords = resultText.ToList();
                    break;
            }

            return Task.FromResult(response);
        }

        public Task<StatisticsResponse> Statistics(StatisticsRequest request)
        {
            StatisticsResponse response = new StatisticsResponse();
            string alphaPart = Regex.Match(request.Parameters.TextToAnalyze, @"[a-zA-Z].*").Value;


            response.Result.TextStatistics.HyphensQuantity = alphaPart.Length;
            response.Result.TextStatistics.WordQuantity = request.Parameters.TextToAnalyze.Length;
            response.Result.TextStatistics.SpacesQuantity = request.Parameters.TextToAnalyze.Split(" ").Length;
            

            return Task.FromResult(response);
        }
    }
}
