using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

namespace CoreDemo.Controllers
{

    public class WriterController : Controller
    {
        WriterManager _writerManager = new WriterManager(new EfWriterRepository());
        [Authorize]
        public IActionResult Index()
        {
            var userMail = User.Identity.Name;
            ViewBag.v = userMail;
            Context ctx = new Context();
            var writerName = ctx.Writers.FirstOrDefault(x => x.WriterMail == userMail).WriterName;
            ViewBag.v2 = writerName;
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }

        public IActionResult WriterMail()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            Context ctx = new Context();
            var userMail = User.Identity.Name;
            var writerId = ctx.Writers.FirstOrDefault(x => x.WriterMail == userMail).WriterID;
            var writerValues = _writerManager.TGetById(writerId);
            return View(writerValues);
        }
        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer, string passwordAgain)
        {
            WriterValidator _writerValidator = new WriterValidator();
            ValidationResult results = _writerValidator.Validate(writer);
            if (results.IsValid && writer.WriterPassword == passwordAgain)
            {
                _writerManager.TUpdate(writer);
                return RedirectToAction("Index", "Dashboard");
            }
            else if (!results.IsValid)
            {
                foreach (var item in results.Errors)
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
            else
            {
                ModelState.AddModelError("PasswordAgain", "Şifrələr uyğun olmadı, zəhmət olmasa yenidən yoxlayın!");
            }
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage writer)
        {
            Writer w = new Writer();
            if (writer.WriterImage != null)
            {
                var extension = Path.GetExtension(writer.WriterImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                writer.WriterImage.CopyTo(stream);
                w.WriterImage = newImageName;
            }
            w.WriterMail = writer.WriterMail;
            w.WriterName = writer.WriterName;
            w.WriterPassword = writer.WriterPassword;
            w.WriterStatus = writer.WriterStatus;
            w.WriterAbout = writer.WriterAbout;

            _writerManager.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
