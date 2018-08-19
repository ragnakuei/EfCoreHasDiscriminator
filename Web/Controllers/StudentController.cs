using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.BLL;

namespace Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentBL _bl;

        public StudentController(StudentBL bl) { _bl = bl; }

        public IActionResult Index()
        {
            var data = _bl.Get();
            return View(data);
        }
    }
}