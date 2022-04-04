using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager _blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            Context ctx = new Context();
            ViewBag.v1 = ctx.Blogs.Count();
            ViewBag.v2 = ctx.Blogs.Where(x => x.WriterID == 1).Count().ToString();
            ViewBag.v3 = ctx.Categories.Count();
            return View();
        }
    }
}
