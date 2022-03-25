using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
