using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        private readonly BlogManager _blogManager = new BlogManager(new EfBlogRepository());
        private readonly CategoryManager _categoryManager = new CategoryManager(new EfCategoryRepository());
        Context ctx = new Context();
        public IActionResult Index()
        {
            var userName = User.Identity.Name;
            var userMail = ctx.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = ctx.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            ViewBag.v1 = _blogManager.GetAll().Count();
            ViewBag.v2 = _blogManager.GetBlogListWithWriter(writerId).Count();
            ViewBag.v3 = _categoryManager.GetAll().Count();
            return View();
        }
    }
}
