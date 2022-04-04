using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager _writerManager = new WriterManager(new EfWriterRepository());
        Context ctx = new Context();
        public IViewComponentResult Invoke()
        {
            var userMail = User.Identity.Name;
            var writerId = ctx.Writers.FirstOrDefault(x => x.WriterMail == userMail).WriterID;
            var values = _writerManager.GetWriterById(writerId);
            return View(values);
        }

    }
}
