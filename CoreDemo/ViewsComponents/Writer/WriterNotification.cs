using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewsComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
