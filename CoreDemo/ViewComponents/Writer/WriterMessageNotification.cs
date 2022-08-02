using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        Message2Manager _messageManager = new Message2Manager(new EfMessage2Repository());
        UserManager _userManager= new UserManager(new EfUserRepository());
        WriterManager _writerManager= new WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            var userName = User.Identity.Name;
            var userMail = _userManager.GetAll().Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = _writerManager.GetAll().Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            var values = _messageManager.GetInboxListByWriter(writerId);
            return View(values);
        }
    }
}
