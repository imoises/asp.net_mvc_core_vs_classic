using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core.Models;

namespace Core.Controllers
{
    public class PruebaController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ValidarUsuario(Usuario u)
        {
            if (ModelState.IsValid)
            {
                return View("Ok");
            }
            else
            {
                return View("Login");
            }
        }
    }
}