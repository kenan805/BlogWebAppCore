using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager _writerManager = new WriterManager(new EfWriterRepository());

        Context ctx = new Context();
        public IViewComponentResult Invoke()
        {
            var userName = User.Identity.Name;
            var userMail = ctx.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = ctx.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            var values = _writerManager.GetWriterById(writerId);
            return View(values);
        }

    }
}
