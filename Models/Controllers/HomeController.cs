using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.Models;
using Microsoft.AspNetCore.Mvc.TagHelpers;
namespace Models.Controllers
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
            return View();
        }




        [BindProperty]


        //poner publico al objeto de enlace       
        public Usuario _Usuario { get; set; }

        //EL METDODO DEBE DE EXISTIR A RENDERISAR EL ACCTION
        public IActionResult setUsuario()
        {
            return Json(_Usuario);
        }
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
