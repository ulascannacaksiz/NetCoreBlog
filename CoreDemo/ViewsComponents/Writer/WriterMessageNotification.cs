using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewsComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
