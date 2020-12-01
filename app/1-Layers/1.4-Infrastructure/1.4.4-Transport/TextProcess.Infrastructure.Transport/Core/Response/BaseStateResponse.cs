namespace TextProcess.Infrastructure.Transport.Core.Response
{
    public class BaseStateResponse
    {
        public bool HasError { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorType { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorDetail { get; set; }
    }
}
