using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCRUDMVCCore.Controllers
{
    public class CookieController : Controller
    {
        public string SetCookie()
        {
            CookieOptions options = new CookieOptions();
            options.Expires = DateTimeOffset.Now.AddSeconds(30);            
            Response.Cookies.Append("SE1619_user", "chilp", options);

            return $"set cookie";
        }
        public string ShowCookie()
        {
            string user = Request.Cookies["SE1619_user"];
            return $"{user}";
        }
    }
}
