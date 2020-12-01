using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using TextProcess.Application.Contracts.TextProcess.Services;
using TextProcess.Application.TextProcess.Services;
using TextProcess.Infrastructure.Data.Contracts.TextProcess.Services;
using TextProcess.Infrastructure.Data.Services.TextProcess.Services;
using TextProcess.Domain.Contracts.TextProcess.Services;
using TextProcess.Domain.TextProcess.Services;
using TextProcess.Infrastructure.Data.CQS.TextProcess.Query;
using TextProcess.Infrastructure.Transport.TextProcess.Request;
using TextProcess.Infrastructure.Transport.TextProcess.CQS.Query.Parameter;

namespace TextProcess.Unit.Tests
{
    [TestClass]
    public class TestProcessTests
    {
        private readonly ITextProcessApplicationService _textProcessApplicationService;
        private readonly ServiceCollection services;

        public TestProcessTests()
        {
            services = new ServiceCollection();
            services.AddTransient<ITextProcessApplicationService, TextProcessApplicationService>();
            services.AddTransient<ITextProcessDomainService, TextProcessDomainService>();
            services.AddTransient<ITextProcessDataService, TextProcessDataService>();
            services.AddTransient<ITextProcessQuery, TextProcessQuery>();
            var serviceProvider = services.BuildServiceProvider();
            _textProcessApplicationService = serviceProvider.GetService<ITextProcessApplicationService>();
        }

        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string resultToCompare = "AlphabeticAsc";

            //Act
            var result = _textProcessApplicationService.OrderOptions().Result;

            //Assert
            Assert.AreEqual(result.Result.OrderOptions.Options.FirstOrDefault(), resultToCompare);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            OrderedTextRequest request = new OrderedTextRequest();
            request.Parameters = new OrderedTextParameter();

            request.Parameters.TextToOrder = "ESTO ES UNA PRUEBA";
            request.Parameters.OrderOption = "AlphabeticAsc";

            string resultToCompare = "ES";

            //Act
            var result = _textProcessApplicationService.OrderedText(request).Result;

            //Assert
            Assert.AreEqual(result.Result.OrderedText.OrderedWords.FirstOrDefault(), resultToCompare);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            StatisticsRequest request = new StatisticsRequest();
            request.Parameters = new StatisticsParameter();
            request.Parameters.TextToAnalyze = "ESTO ES UNA PRUEBA";

            int resultToCompare = 18;

            //Act
            var result = _textProcessApplicationService.Statistics(request).Result;

            //Assert
            Assert.AreEqual(result.Result.TextStatistics.WordQuantity, resultToCompare);
        }
    }
}
