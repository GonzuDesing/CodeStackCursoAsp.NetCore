using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HolaMundo.Models;

namespace HolaMundo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


//IActionResult devuelve cualquier tipo de dato
        public IActionResult Index()
        {
            //Puedo agregar el nombre de la vista a regresar
            return View();
        }

//Los metodos pueden devolver vistas pero no siempre lo hacen
        public string HolaMundo(string Nombre)
        {

            return "Hola "+Nombre;


        }

//AL LLAMRLO EN EL URL DEBO PONER    /Home/nombre del metodo  /Home/Acerca asi me llama la vista acerca
        public ViewResult Acerca()
        {
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
