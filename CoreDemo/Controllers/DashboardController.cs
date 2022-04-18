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
        private readonly BlogManager _blogManager = new BlogManager(new EfBlogRepository());
        private readonly CategoryManager _categoryManager = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            ViewBag.v1 = _blogManager.GetAll().Count();
            ViewBag.v2 = _blogManager.GetBlogListWithWriter(1).Count().ToString();
            ViewBag.v3 = _categoryManager.GetAll().Count();
            return View();
        }
    }
}
