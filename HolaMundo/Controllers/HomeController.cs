using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HolaMundo.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
namespace HolaMundo.Controllers
{
    public class HomeController : Controller
    {
        //Creamos variable privada de la interfaz IWebHostEnvironment
        //Variable de ambiente _env




        private readonly IWebHostEnvironment env;


        public HomeController(IWebHostEnvironment _env)
        {

            env = _env;
        }





        /*
                private readonly ILogger<HomeController> _logger;
                public HomeController(ILogger<HomeController> logger)
                {
                    _logger = logger;
                }
        */

        /*
        //SI SE TIENEN DOS CONTROLADORES IGUALES SE DEBE HACER ASI
               private IWebHostEnvironment _env;
               private readonly ILogger<HomeController> _logger;

               //creamos el constructor

               public HomeController(ILogger<HomeController> logger, IWebHostEnvironment env)
               {
                   _logger = logger;
                   _env = env;
               }

               */


        //IActionResult devuelve cualquier tipo de dato
        public IActionResult Index()
        {
            //Puedo agregar el nombre de la vista a regresar
            return View();
        }





        public IActionResult PDF()
        {

            string FilePath = Path.Combine(env.WebRootPath, "download/", "PruebaPDF.pdf");
            string FilePath404 = Path.Combine(env.WebRootPath, "download/", "NoEncontrado.pdf");
            //Validamos que el archivo exista
            if (System.IO.File.Exists(FilePath))
            {
                //Lo instanciamos para poder utilizarlo
                FileStream fs = new FileStream(FilePath, FileMode.Open);
                //con octed-stream descarga el archivo
                //el segundo parametro va ser el nombre del archivo al descargarse
            
                return File(fs,"application/octet-stream", "Archivo.pdf");
                
            }
            else
            {
                //Lo instanciamos para poder utilizarlo
               return Content("Archivo no encontrado");
            }
        }




        //Los metodos pueden devolver vistas pero no siempre lo hacen
        public string HolaMundo(string Nombre)
        {

            return "Hola " + Nombre;


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
