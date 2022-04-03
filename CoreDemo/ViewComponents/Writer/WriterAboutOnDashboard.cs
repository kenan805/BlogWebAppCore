using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager _writerManager = new WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            var values = _writerManager.GetWriterById(1);
            return View(values);
        }

    }
}
