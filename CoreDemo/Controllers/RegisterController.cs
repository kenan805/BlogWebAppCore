using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager _writerManager = new WriterManager(new EfWriterRepository());
        CityManager _cityManager = new CityManager(new EfCityRepository());
        [HttpGet]
        public IActionResult Index()
        {
            var values = _cityManager.GetAll();
            return View(/*values*/);
        }

        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            WriterValidator _writerValidator = new WriterValidator();
            ValidationResult results = _writerValidator.Validate(writer);
            if (results.IsValid)
            {
                writer.WriterStatus = true;
                writer.WriterAbout = "Test About";
                _writerManager.WriterAdd(writer);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
