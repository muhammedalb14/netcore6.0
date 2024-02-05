using Microsoft.AspNetCore.Mvc;

namespace GB2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult About(int x,int y)
        {
            ViewBag.sum = x + y;
            return View();
        }
    }
}
