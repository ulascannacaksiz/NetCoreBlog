﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    //[Authorize] Controller için geçerli olur
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }
        public IActionResult WriterMail()
        {//View Oluşturmadım
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var writervalues = wm.TGetById(1);
            return View(writervalues);
        }
        [HttpPost]
        public IActionResult WriterEditProfile(Writer p)
        {
            WriterValidator vl = new WriterValidator();
            ValidationResult results = vl.Validate(p);
            if (results.IsValid)
            {
                p.WriterStatus = true;
                wm.TUpdate(p);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach(var v in results.Errors)
                {
                    ModelState.AddModelError(v.PropertyName, v.ErrorMessage);
                }
            }
            return View();
        }

    }
}
