using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCommentController : Controller
    {
        CommentManager _commentManager = new(new EfCommentRepository());
        public IActionResult Index()
        {
            var values = _commentManager.GetCommentListWithBlog();
            return View(values);    
        }
    }
}
