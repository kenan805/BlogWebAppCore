using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        private readonly WriterManager _writerManager = new WriterManager(new EfWriterRepository());
        private readonly CityManager _cityManager = new CityManager(new EfCityRepository());
        //WriterRegisterViewModel _writerRegisterViewModel = new WriterRegisterViewModel();
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Cities = GetCities();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer writer, string passwordAgain)
        {
            //_writerRegisterViewModel.Writer = writer;
            WriterValidator _writerValidator = new WriterValidator();
            ValidationResult results = _writerValidator.Validate(writer);
            if (results.IsValid && writer.WriterPassword == passwordAgain)
            {
                writer.WriterStatus = true;
                writer.WriterAbout = "Test About";
                _writerManager.WriterAdd(writer);
                return RedirectToAction("Index", "Blog");
            }
            else if (!results.IsValid)
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            else
            {
                ModelState.AddModelError("WriterPassword", "Şifrələr uyğun olmadı, zəhmət olmasa yenidən yoxlayın!");
            }
            ViewBag.Cities = GetCities();
            return View();
        }

        public SelectList GetCities()
        {
            var cities = _cityManager.GetAll();
            return new SelectList(cities, "CityID", "CityName");
        }
    }
}
