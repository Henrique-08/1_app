using Microsoft.AspNetCore.Mvc;

namespace _1_app.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nota = "Aluno nota 10";
            ViewData["escola"] = "E.E. Anhanguera";
            return View();
        }
    }
}
