namespace TextProcess.API
{
    using TextProcess.API.Infrastructure.Crosscutting;
    using TextProcess.Infrastructure.Web.Configuration;

    public class Program
    {
        public static void Main(string[] args)
        {
            WebHostHelper.BuildAndRunWebAPI<Program, TextProcessDependenciesConfiguration>(args);
        }
    }
}
