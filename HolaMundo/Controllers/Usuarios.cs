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


    //Muy importante que sellame igual qwue la clase y controller
    public class UsuariosController : Controller
    {



        public IActionResult Index()
        {
            return View();

        }

public IActionResult Registro(bool Encontrado)
{
//devuelve texto plano
if(Encontrado)
    return Content("Registro encontrado");
    else 
    return StatusCode(404);
}

    }


}
       


    
    
