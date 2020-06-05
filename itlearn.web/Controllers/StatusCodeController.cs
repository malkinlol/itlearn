using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itlearn.web.Controllers
{
    public class StatusCodeController : Controller
    {
        [HttpGet("/statusCode/{statusCode}")]
        public IActionResult Index(int statusCode)
        {
            return View(statusCode);
        }
    }
}
