namespace TextProcess.Client.Desktop.Web
{
    using TextProcess.Infrastructure.Web.Configuration;

    public class Program
    {
        public static void Main(string[] args)
        {
            WebHostHelper.BuildAndRunWebApp<Program>(args);
        }
    }
}
