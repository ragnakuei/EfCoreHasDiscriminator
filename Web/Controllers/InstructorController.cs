using Microsoft.AspNetCore.Mvc;
using Web.BLL;

namespace Web.Controllers
{
    public class InstructorController : Controller
    {
        private readonly InstructorBL _bl;

        public InstructorController(InstructorBL bl) { _bl = bl; }

        public IActionResult Index()
        {
            var data = _bl.Get();
            return View(data);
        }
    }
}