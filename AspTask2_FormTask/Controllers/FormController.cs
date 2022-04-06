using AspTask2_FormTask.Entities;
using AspTask2_FormTask.FakeRepo;
using AspTask2_FormTask.Helpers;
using AspTask2_FormTask.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspTask2_FormTask.Controllers
{
    public class FormController : Controller
    {
        private readonly IWebHostEnvironment _webhost;
        public FormController(IWebHostEnvironment webhost)
        {
            _webhost = webhost;
        }
        [HttpGet]
        public IActionResult Add()
        {



            return View();
        }

        
        [HttpPost]
        public async Task<IActionResult> Add(UserViewModel model)
        {
            
            var helper = new ImageHelper(_webhost);
            model.User.ImageUrl = await helper.SaveFile(model.File);
            ClassHelper.UserRepo.users.Add(model.User);
            return RedirectToAction("Index", new { hr = true });
            
        }
    }
}
