using Microsoft.AspNetCore.Mvc;
using sln_demo.Data;
using sln_demo.Models;

namespace sln_demo.Controllers
{
    public class PersonalController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonalController(ApplicationDbContext context)

        {

            _context = context;

        }

        public IActionResult Index()
        {
            IEnumerable<Personal> ListaPersonal = _context.Personal;

            return View(ListaPersonal);
        }
        public IActionResult Create()
        {          

            return View();
        }
        [HttpPost]

        public IActionResult Create(Personal personal)

        {

            if (ModelState.IsValid)

            {

                _context.Personal.Add(personal);

                _context.SaveChanges();



                TempData["aviso"] = "Personal registrado";

                return RedirectToAction("Index");

            }



            return View();

        }
    }
}
