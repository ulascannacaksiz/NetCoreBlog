using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            var CityList = new List<CityList>()
            {
                new CityList{CityId=1,City="ADANA"},
                new CityList{CityId=2,City="ADIYAMAN"},
                new CityList{CityId=3,City="AFYONKARAHİSAR"},
                new CityList{CityId=4,City="AĞRI"},
                new CityList{CityId=5,City="AMASYA"},
                new CityList{CityId=6,City="ANKARA"},
                new CityList{CityId=7,City="ANTALYA"},
                new CityList{CityId=8,City="ARTVİN"},
                new CityList{CityId=9,City="AYDIN"},
                new CityList{CityId=10,City="BALIKESİR"},
                new CityList{CityId=11,City="BİLECİK"},
                new CityList{CityId=12,City="BİNGÖL"},
                new CityList{CityId=13,City="BİTLİS"},
                new CityList{CityId=14,City="BOLU"},
                new CityList{CityId=15,City="BURDUR"},
                new CityList{CityId=16,City="BURSA"},
                new CityList{CityId=17,City="ÇANAKKALE"},
                new CityList{CityId=18,City="ÇANKIRI"},
                new CityList{CityId=19,City="ÇORUM"},
                new CityList{CityId=20,City="DENİZLİ"},
                new CityList{CityId=21,City="DİYARBAKIR"},
                new CityList{CityId=22,City="EDİRNE"},
                new CityList{CityId=23,City="ELAZIĞ"},
                new CityList{CityId=24,City="ERZİNCAN"},
                new CityList{CityId=25,City="ERZURUM"},
                new CityList{CityId=26,City="ESKİŞEHİR"},
                new CityList{CityId=27,City="GAZİANTEP"},
                new CityList{CityId=28,City="GİRESUN"},
                new CityList{CityId=29,City="GÜMÜŞHANE"},
                new CityList{CityId=30,City="HAKKARİ"},
                new CityList{CityId=31,City="HATAY"},
                new CityList{CityId=32,City="ISPARTA"},
                new CityList{CityId=33,City="MERSİN"},
                new CityList{CityId=34,City="İSTANBUL"},
                new CityList{CityId=35,City="İZMİR"},
                new CityList{CityId=36,City="KARS"},
                new CityList{CityId=37,City="KASTAMONU"},
                new CityList{CityId=38,City="KAYSERİ"},
                new CityList{CityId=39,City="KIRKLARELİ"},
                new CityList{CityId=40,City="KIRŞEHİR"},
                new CityList{CityId=41,City="KOCAELİ"},
                new CityList{CityId=42,City="KONYA"},
                new CityList{CityId=43,City="KÜTAHYA"},
                new CityList{CityId=44,City="MALATYA"},
                new CityList{CityId=45,City="MANİSA"},
                new CityList{CityId=46,City="KAHRAMANMARAŞ"},
                new CityList{CityId=47,City="MARDİN"},
                new CityList{CityId=48,City="MUĞLA"},
                new CityList{CityId=49,City="MUŞ"},
                new CityList{CityId=50,City="NEVŞEHİR"},
                new CityList{CityId=51,City="NİĞDE"},
                new CityList{CityId=52,City="ORDU"},
                new CityList{CityId=53,City="RİZE"},
                new CityList{CityId=54,City="SAKARYA"},
                new CityList{CityId=55,City="SAMSUN"},
                new CityList{CityId=56,City="SİİRT"},
                new CityList{CityId=57,City="SİNOP"},
                new CityList{CityId=58,City="SİVAS"},
                new CityList{CityId=59,City="TEKİRDAĞ"},
                new CityList{CityId=60,City="TOKAT"},
                new CityList{CityId=61,City="TRABZON"},
                new CityList{CityId=62,City="TUNCELİ"},
                new CityList{CityId=63,City="ŞANLIURFA"},
                new CityList{CityId=64,City="UŞAK"},
                new CityList{CityId=65,City="VAN"},
                new CityList{CityId=66,City="YOZGAT"},
                new CityList{CityId=67,City="ZONGULDAK"},
                new CityList{CityId=68,City="AKSARAY"},
                new CityList{CityId=69,City="BAYBURT"},
                new CityList{CityId=70,City="KARAMAN"},
                new CityList{CityId=71,City="KIRIKKALE"},
                new CityList{CityId=72,City="BATMAN"},
                new CityList{CityId=73,City="ŞIRNAK"},
                new CityList{CityId=74,City="BARTIN"},
                new CityList{CityId=75,City="ARDAHAN"},
                new CityList{CityId=76,City="IĞDIR"},
                new CityList{CityId=77,City="YALOVA"},
                new CityList{CityId=78,City="KARABÜK"},
                new CityList{CityId=79,City="KİLİS"},
                new CityList{CityId=80,City="OSMANİYE"},
                new CityList{CityId=81,City="DÜZCE"},
            };
            ViewBag.Cities = CityList;
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p)
        {
            WriterValidator wv = new WriterValidator();
            ValidationResult results = wv.Validate(p);
            if (results.IsValid)
            {
                p.WriterStatus = true;
                p.WriterAbout = "Deneme Test";
                wm.WriterAdd(p);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
    }
}
