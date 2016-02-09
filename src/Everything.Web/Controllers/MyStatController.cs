using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Everything.Web.Controllers
{
    public class MyStatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
