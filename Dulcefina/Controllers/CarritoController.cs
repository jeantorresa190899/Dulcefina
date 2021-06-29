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
    public class CarritoController : Controller
    {

        //inyectar las dependencias
        public readonly IUsuarioRepository _usuarioRepository;
        public CarritoController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        //fin de dependencias

        public IActionResult Index()
        {
            var Objsesion = HttpContext.Session.GetString("scliente");
            if (Objsesion == null)
            {
                return RedirectToAction("log", "Principal");
            }
            else
            {              
                ViewBag.detalles = Listar(detalle);
                return View();

            }

        }

        public List<DetallePedido> detalle = new List<DetallePedido>();
        public void agregarCarrito(DetallePedido detallePedido)
        {
            if (ModelState.IsValid)
            {
                detalle.Add(detallePedido);
                RedirectToAction("Index", "Carrito");
            }
            else
            {
                //Falta
            }
        }

       public List<DetallePedido>Listar(List<DetallePedido> detalle)
        {

            return detalle;
        }


    }
}
