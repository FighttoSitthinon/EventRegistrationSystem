using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Mvc;

namespace EventRegistrationSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AntiForgeryController : Controller
    {
        private IAntiforgery _antiForgery;
        public AntiForgeryController(IAntiforgery antiForgery)
        {
            _antiForgery = antiForgery;
        }

        [HttpGet("/")]
        [IgnoreAntiforgeryToken]
        public IActionResult GenerateAntiForgeryTokens()
        {
            var tokens = _antiForgery.GetAndStoreTokens(HttpContext);
            Response.Cookies.Append("XSRF-REQUEST-TOKEN", tokens.RequestToken, new Microsoft.AspNetCore.Http.CookieOptions
            {
                HttpOnly = false,
                Secure = true,
            });
            return NoContent();
        }
    }
}
