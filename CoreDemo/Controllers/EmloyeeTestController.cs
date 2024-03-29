﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class EmloyeeTestController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var responseMsg = await httpClient.GetAsync("https://localhost:44351/api/Default");
            var jsonString = await responseMsg.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Class1>>(jsonString);

            return View(values);
        }
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Class1 p)
        {
            var httpClient = new HttpClient();
            var jsonEmployee = JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(jsonEmployee, Encoding.UTF8, "application/json");
            var responseMsg = await httpClient.PostAsync("https://localhost:44351/api/Default",content);
            if (responseMsg.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(p);
        }
        [HttpGet]
        public async Task<IActionResult> EditEmployee(int id)
        {
            var httpClient = new HttpClient();
            var responseMsg = await httpClient.GetAsync("https://localhost:44351/api/Default/"+id);
            if (responseMsg.IsSuccessStatusCode)
            {
                var jsonEmployee = await responseMsg.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Class1>(jsonEmployee);
                return View(values);
            }
           return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> EditEmployee(Class1 p)
        {
            var httpClient = new HttpClient();
            var jsonEmployee = JsonConvert.SerializeObject(p);
            var content = new StringContent(jsonEmployee, Encoding.UTF8, "application/json");
            var responseMsg = await httpClient.PutAsync("https://localhost:44351/api/Default/", content);
            if (responseMsg.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(p); 
        }
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var httpClient = new HttpClient();
            var responseMsg = await httpClient.DeleteAsync("https://localhost:44351/api/Default/" + id);
            if (responseMsg.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public class Class1
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}
