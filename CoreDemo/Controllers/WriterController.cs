using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{

    public class WriterController : Controller
    {
        private readonly WriterManager _writerManager = new WriterManager(new EfWriterRepository());
        private readonly UserManager userManager = new UserManager(new EfUserRepository());
        private readonly UserManager<AppUser> _userManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            var userMail = User.Identity.Name;
            ViewBag.v = userMail;
            Context ctx = new Context();
            //var writerName = _writerManager.GetAll().FirstOrDefault(x => x.WriterMail == userMail).WriterName;
            var writerName = _writerManager.GetAll().Where(x => x.WriterMail == userMail).Select(y => y.WriterName).FirstOrDefault();
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
        public async Task<IActionResult> WriterEditProfile()
        {
            //Context ctx = new Context();
            //var userName = User.Identity.Name;
            //var userMail = ctx.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            //var id = ctx.Users.Where(x => x.Email == userMail).Select(y => y.Id).FirstOrDefault();
            //var user = userManager.TGetById(id);
            //return View(user);
            //
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateViewModel model = new UserUpdateViewModel();
            model.Mail = user.Email;
            model.FullName = user.Fullname;
            model.ImageUrl = user.ImageUrl;
            model.UserName = user.UserName;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> WriterEditProfile(UserUpdateViewModel model /*AppUser writer, string passwordAgain*/)
        {
            //WriterValidator _writerValidator = new WriterValidator();
            //ValidationResult results = _writerValidator.Validate(writer);
            //if (results.IsValid && writer.WriterPassword == passwordAgain)
            //{
            //    _writerManager.TUpdate(writer);
            //    return RedirectToAction("Index", "Dashboard");
            //}
            //else if (!results.IsValid)
            //{
            //    foreach (var item in results.Errors)
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //}
            //else
            //{
            //    ModelState.AddModelError("PasswordAgain", "Şifrələr uyğun olmadı, zəhmət olmasa yenidən yoxlayın!");
            //}
            //return View();
            //
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Email = model.Mail;
            user.Fullname = model.FullName;
            user.ImageUrl = model.ImageUrl;
            var result = await _userManager.UpdateAsync(user);
            return RedirectToAction("Index", "Dashboard");
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
