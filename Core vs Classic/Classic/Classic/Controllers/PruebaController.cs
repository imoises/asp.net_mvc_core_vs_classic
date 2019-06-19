using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Classic.Models;

namespace Classic.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ValidarUsuario(Usuario u)
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