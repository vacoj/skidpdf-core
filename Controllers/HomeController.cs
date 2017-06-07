using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace skidpdf_core.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        // GET api/values
        [HttpGet]
        public ContentResult Get()
        {
            return new ContentResult
            {
                Content = "<strong>This is just a placeholder.  Since WebSuperGoo doens't seem to support DotNetCore, this is meaningless.</strong>",
                ContentType = "text/html"
            };
        }
    }
}
