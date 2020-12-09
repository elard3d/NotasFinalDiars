using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NotasFinalDiars.Models;
using NotasFinalDiars.Models.BD;

namespace NotasFinalDiars.Controllers
{
    public class NotasController : Controller
    {

        public NotasContext _context { get; set; }

        public NotasController(NotasContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {

            ViewBag.Notas = _context.Notas.ToList();
            return View();
        }


        [HttpGet]

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Crear(string titulo, string contenido)
        {
            Notas nota = new Notas();
            nota.tituloNota = titulo;
            nota.contenidoNota = contenido;
            nota.fechaModicacion = DateTime.Now;

            _context.Notas.Add(nota);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]

        public IActionResult Editar(int id)
        {
            ViewBag.NotaComoTal = _context.Notas.Where(o => o.idNota == id).FirstOrDefault();
            return View();
        }

        [HttpPost]

        public IActionResult Editar(string titulo, string contenido, int idNo)
        {
            Notas nota = _context.Notas.Where(o => o.idNota == idNo).FirstOrDefault();
            nota.tituloNota = titulo;
            nota.contenidoNota = contenido;
            nota.fechaModicacion = DateTime.Now;

            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Borrar(int id)
        {
            var nota = _context.Notas.Where(o => o.idNota == id).FirstOrDefault();

            _context.Remove(nota);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }




    }
}
