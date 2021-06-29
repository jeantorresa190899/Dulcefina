using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dulcefina.Controllers
{
    public class CarritoController : Controller
    {
        public IActionResult Index()
        {
            var Objsesion = HttpContext.Session.GetString("scliente");
            if (Objsesion == null)
            {
                return RedirectToAction("log", "Principal");
            }
            else
            {
                return View();
            }

        }
    }
}
