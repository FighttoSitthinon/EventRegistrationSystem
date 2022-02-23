using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Mvc;

namespace EventRegistrationSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AntiForgeryController : Controller
    {
        //private IAntiforgery _antiForgery;
        //public AntiForgeryController(IAntiforgery antiForgery)
        //{
        //    _antiForgery = antiForgery;
        //}

        //[HttpGet("/")]
        //[IgnoreAntiforgeryToken]
        //public IActionResult GenerateAntiForgeryTokens()
        //{
        //    var tokens = _antiForgery.GetAndStoreTokens(HttpContext);
        //    Response.Cookies.Append("X-XSRF-TOKEN", tokens.RequestToken, new Microsoft.AspNetCore.Http.CookieOptions
        //    {
        //        HttpOnly = false,
        //        Secure = true,
        //    });
        //    return NoContent();
        //}

        //// AntiForgery Token Issues )=w=)\
        ////https://stackoverflow.com/questions/59439732/how-to-validate-antiforgerytoken-issued-from-one-application-on-different-applic
        ////https://stackoverflow.com/questions/48038980/why-antiforgerytoken-validation-keeps-failing
        ////https://www.blinkingcaret.com/2018/11/29/asp-net-core-web-api-antiforgery/
        ////https://docs.microsoft.com/en-us/aspnet/core/security/anti-request-forgery?view=aspnetcore-6.0
    }
}
