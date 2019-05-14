using Microsoft.AspNetCore.Antiforgery;
using Psy.Controllers;

namespace Psy.Web.Host.Controllers
{
    public class AntiForgeryController : PsyControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
