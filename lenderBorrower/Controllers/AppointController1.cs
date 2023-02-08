using Microsoft.AspNetCore.Mvc;

namespace lenderBorrower.Controllers
{
    public class AppointController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            return Ok("This is the id" + id);
        }
    }
}
