using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        MessageManager _messageManager = new MessageManager(new EfMessageRepository());
        public IViewComponentResult Invoke()
        {
            string param;
            param = "deneme@gmail.com";
            var values = _messageManager.GetInboxListByWriter(param);
            return View(values);
        }
    }
}
