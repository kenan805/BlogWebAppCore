using BusinessLayer.Concrete;
using ClosedXML.Excel;
using CoreDemo.Areas.Admin.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly BlogManager _blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult BlogTitleListExcel()
        {
            return View();
        }

        public IActionResult ExportDynamicExcelBloglist()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog list");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog name";

                int blogRowCount = 2;
                foreach (var item in GetBlogTitleList())
                {
                    worksheet.Cell(blogRowCount, 1).Value = item.ID;
                    worksheet.Cell(blogRowCount, 2).Value = item.BlogName;
                    blogRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "CoreDemoBlogListExcel.xlsx");
                }
            }
        }

        public List<BlogModel> GetBlogTitleList()
        {
            List<BlogModel> blogModels = new List<BlogModel>();
            blogModels = _blogManager.GetAll().Select(x => new BlogModel
            {
                ID = x.BlogID,
                BlogName = x.BlogTitle
            }).ToList();

            return blogModels;
        }
    }
}
