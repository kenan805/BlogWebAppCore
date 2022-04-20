using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2 : ViewComponent
    {
        private readonly BlogManager _blogManager = new BlogManager(new EfBlogRepository());
        private readonly ContactManager _contactManager = new ContactManager(new EfContactRepository());
        private readonly CommentManager _commentManager = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke()
        {
            ViewBag.lastBlog = _blogManager.GetAll().OrderByDescending(x => x.BlogCreateDate).Select(x => x.BlogTitle).FirstOrDefault();
            ViewBag.msgCount = _contactManager.GetAll().Count;
            ViewBag.commentCount = _commentManager.GetAll().Count;
            return View();
        }
    }
}
