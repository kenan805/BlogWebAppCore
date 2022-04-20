using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        private readonly BlogManager _blogManager = new BlogManager(new EfBlogRepository());
        private readonly ContactManager _contactManager = new ContactManager(new EfContactRepository());
        private readonly CommentManager _commentManager = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke()
        {
            ViewBag.blogCount = _blogManager.GetAll().Count;
            ViewBag.msgCount = _contactManager.GetAll().Count;
            ViewBag.commentCount = _commentManager.GetAll().Count;
            string api = "dbcbf7e856889a316738d4e3aa55302d";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Baku&mode=xml&lang=az&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.temp = document.Descendants("temperature").ElementAt(0).FirstAttribute.Value;
            return View();
        }
    }
}
