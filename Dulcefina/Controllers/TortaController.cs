using Dulcefina.Models.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dulcefina.Controllers
{
    public class TortaController : Controller
    {
        //inyectar las dependencias
        private readonly ITortaRepository _tortaRepository;
        public TortaController(ITortaRepository tortaRepository)
        {
            _tortaRepository = tortaRepository;
        }
        //fin de dependencias

        public IActionResult EscogerTorta()
        {
            ViewBag.torta = _tortaRepository.GetAllTorta();
            ViewBag.topping = _tortaRepository.GetAllTopping();
            return View();

        }




    }
}
