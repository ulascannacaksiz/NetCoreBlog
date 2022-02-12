using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewsComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
