using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterNoticeNotification : ViewComponent
    {
        NotificationManager _notificationManager = new NotificationManager(new EfNotificationRepository());
        public IViewComponentResult Invoke()
        {
            var values = _notificationManager.GetAll();
            return View(values);
        }
    }
}
