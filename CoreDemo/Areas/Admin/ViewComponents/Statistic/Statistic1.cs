using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = bm.GetList().Count();
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Comments.Count();
            string api = "Your api key";
            // string connection = "http://api.weatherapi.com/v1/current.xml?key="+api+"&q=İstanbul";
            //XDocument document = XDocument.Load(connection);
            //ViewBag.v4 = document.Descendants("temp_c").First().Value;
            ViewBag.v4 = 12;
            return View();
        }
    }
}
