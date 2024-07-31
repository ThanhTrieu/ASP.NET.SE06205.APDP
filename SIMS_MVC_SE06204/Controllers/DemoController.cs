using Microsoft.AspNetCore.Mvc;

namespace SIMS_MVC_SE06204.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Test(int age, string address)
        {
            ViewData["myAge"] = age;
            ViewData["myAddress"] = address;
            return View();
        }
    }
}
