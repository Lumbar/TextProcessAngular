namespace TextProcess.Infrastructure.Transport.Core.Response
{
    public class BaseResponse
    {
        public BaseStateResponse State { get; set; }

        public BaseResponse()
        {
            State = new BaseStateResponse();
        }

        public static BaseResponse Ok()
        {
            return new BaseResponse { State = new BaseStateResponse { HasError = false } };
        }

        public static BaseResponse Ok(string message)
        {
            return new BaseResponse { State = new BaseStateResponse { HasError = false, ErrorMessage = message } };
        }

        public static BaseResponse Failed(string message)
        {
            return new BaseResponse { State = new BaseStateResponse { HasError = true, ErrorMessage = message } };
        }
    }
}
