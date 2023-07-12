using Microsoft.AspNetCore.Mvc;
using sln_demo.Data;
using sln_demo.Models;
using System.Collections.Generic;

namespace sln_demo.Controllers
{
    public class HistorialVuelosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HistorialVuelosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<HistorialVuelos> listaVuelos = _context.Set<HistorialVuelos>();
            return View(listaVuelos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(HistorialVuelos vuelo)
        {
            if (ModelState.IsValid)
            {
                _context.Set<HistorialVuelos>().Add(vuelo);
                _context.SaveChanges();

                TempData["aviso"] = "Vuelo registrado";
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
