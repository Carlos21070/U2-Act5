using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using U2_Act5.Models;
using U2_Act5.Models.ViewModels;

namespace U2_Act5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            animalesContext context = new animalesContext();
            ClasificacionViewModel cvm = new ClasificacionViewModel();
            cvm.Clasificacion = context.Clase.OrderBy(x => x.Nombre.ToUpper());
            Random r = new Random();
            cvm.NumImg = r.Next(1, 6);
            return View(cvm);
        }

        [Route("Clasificacion/{id}")]
        public IActionResult Clasificacion(string id)
        {
            animalesContext context = new animalesContext();
            var nombre = id.Replace("-", " ").ToUpper();
            var especies = context.Clase.Include(x => x.Especies).Where(x => x.Nombre.ToUpper() == nombre).OrderBy(x => x.Nombre);
            if (especies.Count() == 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(especies);
            }

        }
    }
}
