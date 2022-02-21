﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewsComponents.Blog
{
    public class BlogListDashboard:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
    }
}
