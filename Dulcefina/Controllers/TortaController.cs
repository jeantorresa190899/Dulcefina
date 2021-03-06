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


        public IActionResult opcTortas()
        {
            ViewBag.tortas = _tortaRepository.GetAllTorta();
            return View(_tortaRepository.GetAllTorta());           
        }

      
        public IActionResult EscogerTorta(string id)
        {
            ViewBag.torta = _tortaRepository.GetAllTorta();
            ViewBag.topping = _tortaRepository.GetAllTopping();
            var obj = _tortaRepository.VerDetalleTorta(id);
            ViewData["idTorta"] = obj.IdTorta;
            ViewData["porcion"] = obj.Porcion;
            ViewData["sabor"] = obj.Sabor;
            ViewData["relleno"] = obj.Relleno;
            ViewData["precio"] = obj.Precio;
            ViewData["color"] = obj.Color;
            ViewData["foto"] = obj.Foto;
            return View();
        }





    }
}
