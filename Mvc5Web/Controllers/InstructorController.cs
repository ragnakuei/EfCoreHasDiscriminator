using System.Web.Mvc;
using Mvc5Web.BLL;
using Mvc5Web.EF;

namespace Mvc5Web.Controllers
{
    public class InstructorController : Controller
    {
        private readonly InstructorBL _bl;

        public InstructorController()
        {
            var dbContext = new DemoDbContext();
            _bl = new InstructorBL(dbContext);
        }

        public ActionResult Index()
        {
            var data = _bl.Get();
            return View(data);
        }
    }
}