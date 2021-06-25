using Dulcefina.Models;
using Dulcefina.Models.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dulcefina.Controllers
{
    public class IngresoController : Controller
    {
        //inyectar las dependencias
        public readonly IUsuarioRepository _usuarioRepository;
        public IngresoController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        //fin de dependencias

        public IActionResult Bienvenido()
        {
            var Objsesion = HttpContext.Session.GetString("scliente");
            if (Objsesion != null)
            {
                //Deserializar el objeto 
                var Obj = JsonConvert.DeserializeObject<Cliente>(HttpContext.Session.GetString("scliente"));
               
                ViewBag.cliente = _usuarioRepository.Datos(Obj.Correo).Correo; 
                return View(_usuarioRepository.GetAllUsuarios());
            }
            else
            {
                return RedirectToAction("log", "Principal"); //return View();
            }
        }
    }
}
