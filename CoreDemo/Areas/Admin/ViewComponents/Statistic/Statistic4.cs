using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4 : ViewComponent
    {
        AdminManager _adminManager = new AdminManager(new EfAdminRepository());
        public IViewComponentResult Invoke()
        {
            ViewBag.adminName = _adminManager.GetAll().Where(x => x.AdminID == 1).Select(x => x.Name).FirstOrDefault();
            ViewBag.adminImg = _adminManager.GetAll().Where(x => x.AdminID == 1).Select(x => x.ImageUrl).FirstOrDefault();
            ViewBag.desc = _adminManager.GetAll().Where(x => x.AdminID == 1).Select(x => x.ShortDescription).FirstOrDefault();
            
            return View();
        }
    }
}
