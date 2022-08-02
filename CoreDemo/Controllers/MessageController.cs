using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    //[AllowAnonymous]
    public class MessageController : Controller
    {
        private readonly Message2Manager _messageManager = new(new EfMessage2Repository());
        private readonly UserManager _userManager = new(new EfUserRepository());
        private readonly WriterManager _writerManager = new(new EfWriterRepository());
        public IActionResult InBox()
        {
            var userName = User.Identity.Name;
            var userMail = _userManager.GetAll().Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = _writerManager.GetAll().Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            var values = _messageManager.GetInboxListByWriter(writerId);
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var msgValue = _messageManager.TGetById(id);

            return View(msgValue);
        }

        public IActionResult DeleteMessage(int id)
        {
            var message = _messageManager.TGetById(id);
            _messageManager.TDelete(message);
            return RedirectToAction("InBox", "Message");
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message2 msg, string receiverMail)
        {
            var userName = User.Identity.Name;
            var userMail = _userManager.GetAll().Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = _writerManager.GetAll().Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            var receiverId = _writerManager.GetAll().Where(x => x.WriterMail == receiverMail).Select(y => y.WriterID).FirstOrDefault();
            msg.SenderID = writerId;
            msg.ReceiverID = receiverId;
            msg.MessageStatus = true;
            msg.MessageDate = DateTime.Now;
            _messageManager.TAdd(msg);
            return RedirectToAction("InBox");
        }

        public IActionResult SendBox()
		{
            var userName = User.Identity.Name;
            var userMail = _userManager.GetAll().Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = _writerManager.GetAll().Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            var values = _messageManager.GetSendBoxListByWriter(writerId);
            return View(values);
        }
    }
}
