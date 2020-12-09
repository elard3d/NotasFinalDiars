using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotasFinalDiars.Models;
using NotasFinalDiars.Models.BD;

namespace NotasFinalDiars.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public NotasContext _context { get; set; }

        public HomeController(ILogger<HomeController> logger, NotasContext context)
        {
            _logger = logger;
            this._context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Etiquetas = _context.Etiquetas.ToList();
            ViewBag.Notas = _context.Notas.ToList();
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
