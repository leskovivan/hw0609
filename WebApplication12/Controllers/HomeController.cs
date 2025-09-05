using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication12.Models;

namespace WebApplication1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person person)
        {
            if (ModelState.IsValid)
            {
                return Content("Ok");
            }
            return View(person);
        }

        [AllowAnonymous]
        public IActionResult CheckUniqueUsername(string uniqueUsername)
        {
            if (uniqueUsername.Equals("Admin"))
            {
                return Json(false); 
            }
            return Json(true); 
        }
    }
}
