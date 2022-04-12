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
using System.Web;

namespace AspTask2_FormTask.Controllers
{
    public class HomeController : Controller
    {


        private readonly IWebHostEnvironment _webhost;

        public HomeController(IWebHostEnvironment webhost)
        {
            _webhost = webhost;
        }

        FakeRepo.UserRepo UserRepo = new FakeRepo.UserRepo();


        [HttpGet] 


        public IActionResult Index()
        {


            return View(UserRepo.GetAllUsers());
        }

        
        public IActionResult Add()
        {
            UserViewModel userViewModel = new UserViewModel
            {
                User = new User()
            };

            return View(userViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Add(UserViewModel model)
        {
            var helper = new ImageHelper(_webhost);
            model.User.ImageUrl = await helper.SaveFile(model.File);
            FakeRepo.UserRepo.users.Add(model.User);
            return RedirectToAction("Index");
        }




    }
}
