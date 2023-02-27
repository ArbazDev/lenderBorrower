using lenderBorrower.Data;
using Microsoft.AspNetCore.Mvc;

namespace lenderBorrower.Controllers
{
    public class itemController : Controller
    {
        private readonly ApplicationDbContext _db;
        public IActionResult Index()
        {
            return View();
        }
    }
}
