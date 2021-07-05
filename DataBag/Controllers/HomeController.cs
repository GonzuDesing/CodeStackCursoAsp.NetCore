using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DataBag.Models;

namespace DataBag.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Nombre = "Jose carlos";
            ViewData["Apellido"] = "Fuentes Campos";
            TempData["Usuario"] = "Jose";

            List<string> Frutas = new List<string>()
          {
              "Manzans","Peras","Uvas","Mandarinas"

          };

            ViewData["Frutas"] = Frutas;
            ViewBag.Frutas = Frutas;
            TempData["Frutas"] = Frutas;
            return View();
        }

//Creamos un controllador completo para la clase(modelo) usuario
        public IActionResult Usuarios()
        {
            ViewData["Usuarios"] = new List<Usuario>()

           // List<Usuario> Usuarios = new List<Usuario>()
            {
                new Usuario()
                {
                    Nombre="Jose Carlos",
                    Apellido="Gonzalez Ulate",
                    Correo="gonzu.desing@gmail.com",
                    Edad=24

                },

                 new Usuario()
                {
                    Nombre="Noah",
                    Apellido="Gonzalez Guzman",
                    Correo="noah.desing@gmail.com",
                    Edad=18

                },

                 new Usuario()
                {
                    Nombre="Valeria",
                    Apellido="Arias Castro",
                    Correo="vale.desing@gmail.com",
                    Edad=18

                }

            };

//El viewdata se puede instanciar al inicio o igualar al final
            //ViewData["Usuarios"]=Usuarios;
            return View();
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
