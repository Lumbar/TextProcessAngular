namespace TextProcess.Infrastructure.Web.API
{
    using ExceptionHandling;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [ServiceFilter(typeof(ApiExceptionFilter))]
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    [EnableCors("AllowAllCORS")]
    public class BaseController : ControllerBase
    {
        public BaseController()
        {
        }
    }
}
