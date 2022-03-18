﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewsComponents.Writer
{
    public class WriterAboutDashboard:ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        Context c = new Context();



        public IViewComponentResult Invoke()
        {

            var username = User.Identity.Name;
            var usermail = c.Users.Where(x=>x.UserName == username).Select(y=>y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = wm.GetWriterById(writerID);
            return View(values);
        }
    }
}
