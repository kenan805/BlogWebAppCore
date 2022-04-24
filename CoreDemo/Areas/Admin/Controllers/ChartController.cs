using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryModel> list = new List<CategoryModel>();
            list.Add(new CategoryModel { categoryname = "Texno", categorycount = 10 });
            list.Add(new CategoryModel { categoryname = "Idman", categorycount = 14 });
            list.Add(new CategoryModel { categoryname = "Proqramlasdirma", categorycount = 5 });

            return Json(new { jsonlist = list });
        }
    }
}
