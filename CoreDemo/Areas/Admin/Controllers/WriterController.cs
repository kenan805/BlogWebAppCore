using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreDemo.Areas.Admin.Controllers
{
	[Area("Admin")]
    public class WriterController : Controller
    {
        private readonly WriterManager _writerManager = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(_writerManager.GetAll());
            return Json(jsonWriters);
        }

        public IActionResult GetWriterById(int writerId)
        {
            var findWriter = _writerManager.TGetById(writerId);
            var jsonWriter = (findWriter != null) ? JsonConvert.SerializeObject(findWriter) : null;
            return Json(jsonWriter);
        }

        [HttpPost]
        public IActionResult AddWriter(Writer writer)
        {
            _writerManager.TAdd(writer);
            var jsonWriters = (writer != null) ? JsonConvert.SerializeObject(_writerManager.GetAll()) : null;
            return Json(jsonWriters);
        }

        public IActionResult DeleteWriter(int writerId)
        {
            var writer = _writerManager.TGetById(writerId);
            _writerManager.TDelete(writer);
            return Json(writer);
        }

        public IActionResult UpdateWriter(Writer writer)
        {
            _writerManager.TUpdate(writer);
            var jsonWriter = JsonConvert.SerializeObject(writer);
            return Json(jsonWriter);
        }

    }
}
