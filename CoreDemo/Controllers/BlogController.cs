﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogManager _blogManager = new(new EfBlogRepository());
        private readonly CategoryManager _categoryManager = new(new EfCategoryRepository());
        private readonly WriterManager _writerManager = new(new EfWriterRepository());
        private readonly UserManager _userManager = new(new EfUserRepository());

        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = _blogManager.GetBlogListWithCategory();
            return View(values);
        }
        [AllowAnonymous]
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = _blogManager.GetBlogsById(id);
            return View(values);
        }
        public IActionResult BlogListByWriter()
        {
            var userName = User.Identity.Name;
            var userMail = _userManager.GetAll().Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = _writerManager.GetAll().Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            var blogs = _blogManager.GetBlogListWithCategoryByWriter(writerId);
            return View(blogs);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            List<SelectListItem> categoryValues = (from x in _categoryManager.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.categoryValues = categoryValues;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {
            var userName = User.Identity.Name;
            var userMail = _userManager.GetAll().Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = _writerManager.GetAll().Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            BlogValidator _blogValidator = new BlogValidator();
            ValidationResult results = _blogValidator.Validate(blog);
            if (results.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.WriterID = writerId;
                _blogManager.TAdd(blog);
                return RedirectToAction("BlogListByWriter", "Blog");
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
        public IActionResult DeleteBlog(int id)
        {
            var blogValue = _blogManager.TGetById(id);
            _blogManager.TDelete(blogValue);
            return RedirectToAction("BlogListByWriter", "Blog");
        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogValue = _blogManager.TGetById(id);
            List<SelectListItem> categoryValues = (from x in _categoryManager.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.categoryValues = categoryValues;
            return View(blogValue);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {
            var userName = User.Identity.Name;
            var userMail = _userManager.GetAll().Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = _writerManager.GetAll().Where(x => x.WriterMail == userMail).Select(y=>y.WriterID).FirstOrDefault();
            blog.WriterID = writerId;
            blog.BlogCreateDate = DateTime.Parse(_blogManager.TGetById(blog.BlogID).BlogCreateDate.ToShortDateString());
            blog.BlogStatus = true;
            _blogManager.TUpdate(blog);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
