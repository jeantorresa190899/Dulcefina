using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dulcefina.Models.Interface;
using Dulcefina.Models;

namespace Dulcefina.Controllers
{
    public class PrincipalController : Controller
    {
        //inyectar las dependencias
        private readonly IUsuarioRepository _clienteRepository;
        private readonly ITortaRepository _tortaRepository;
        public PrincipalController(IUsuarioRepository usuarioRepository, ITortaRepository tortaRepository)
        {
            _clienteRepository = usuarioRepository;
            _tortaRepository = tortaRepository;
        }
        //fin de dependencias

     
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult log()
        {
            return View();
        }

        public IActionResult register()
        {
            return View();
        }




        public IActionResult RegisterUsuario(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _clienteRepository.Add(cliente);
                return RedirectToAction("log");
            }
            else
            {
                return View("register");
            }
        }


        public IActionResult escoger()
        {
            return View();
        }


        public IActionResult Listartorta()
        {
            _tortaRepository.
            return View();
        }



    }
}
