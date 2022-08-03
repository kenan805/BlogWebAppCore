using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly Message2Manager _messageManager = new(new EfMessage2Repository());
        private readonly UserManager _userManager = new(new EfUserRepository());
        private readonly WriterManager _writerManager = new(new EfWriterRepository());
        public IActionResult Inbox()
        {
            var userName = User.Identity.Name;
            var userMail = _userManager.GetAll().Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = _writerManager.GetAll().Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            var values = _messageManager.GetInboxListByWriter(writerId);
            return View(values);
        }

        public IActionResult SendBox()
        {
            var userName = User.Identity.Name;
            var userMail = _userManager.GetAll().Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = _writerManager.GetAll().Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            var values = _messageManager.GetSendBoxListByWriter(writerId);
            return View(values);
        }

        [HttpGet]
        public IActionResult ComposeMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ComposeMessage(Message2 msg)
        {
            var userName = User.Identity.Name;
            var userMail = _userManager.GetAll().Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = _writerManager.GetAll().Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            msg.SenderID = writerId;
            msg.ReceiverID = 2;
            msg.MessageDate = DateTime.Now;
            msg.MessageStatus = true;
            _messageManager.TAdd(msg); 
            return RedirectToAction("SendBox");
        }
    }
}
