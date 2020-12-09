using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NotasFinalDiars.Models;
using NotasFinalDiars.Models.BD;

namespace NotasFinalDiars.Controllers
{
    public class NotaEtiquetaController : Controller
    {
        public NotasContext _context { get; set; }

        public NotaEtiquetaController(NotasContext context)
        {
            this._context = context;
        }
 
        public IActionResult Index(int idEtiqueta)
        {
            ViewBag.Notas = _context.NotaEtiquetas.Include(o => o.notas).Include(o => o.etiquetas).Where(o => o.idEtiqueta == idEtiqueta).ToList();
            return View();
        }
        [HttpGet]
        public IActionResult Crear(int id)
        {

            ViewBag.idNota = id;
            ViewBag.Etiquetas = _context.Etiquetas.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Crear(int idEtiquetaNombre, int idEtiqueta)
        {
            NotaEtiqueta notaEtiqueta = new NotaEtiqueta();
            notaEtiqueta.idNota = idEtiquetaNombre;
            notaEtiqueta.idEtiqueta = idEtiqueta;
            _context.NotaEtiquetas.Add(notaEtiqueta);

            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }


    }
}
