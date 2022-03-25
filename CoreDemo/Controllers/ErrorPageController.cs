using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
