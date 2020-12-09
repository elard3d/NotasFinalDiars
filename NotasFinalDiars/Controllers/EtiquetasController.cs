using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotasFinalDiars.Models;
using NotasFinalDiars.Models.BD;

namespace NotasFinalDiars.Controllers
{
    public class EtiquetasController : Controller
    {

        public NotasContext _context { get; set; }

        public EtiquetasController(NotasContext context) {
            this._context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Etiquetas = _context.Etiquetas.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Crear(string nombre, string descripcion)
        {
            Etiquetas etiqueta = new Etiquetas();
            etiqueta.nombreetiqueta = nombre;
            etiqueta.descripcionEtiqueta = descripcion;

            _context.Add(etiqueta);

            _context.SaveChanges();

            return RedirectToAction("Index", "Etiqueta");
        }

    }
}
