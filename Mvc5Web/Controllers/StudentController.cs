using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc5Web.BLL;
using Mvc5Web.EF;

namespace Mvc5Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentBL _bl;

        public StudentController()
        {
            var dbContext = new DemoDbContext();
            _bl = new StudentBL(dbContext);
        }

        public ActionResult Index()
        {
            var data = _bl.Get();
            return View(data);
        }
    }
}