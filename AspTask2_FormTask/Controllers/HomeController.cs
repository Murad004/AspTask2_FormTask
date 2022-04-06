using AspTask2_FormTask.Entities;
using AspTask2_FormTask.FakeRepo;
using AspTask2_FormTask.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspTask2_FormTask.Controllers
{
    public class HomeController : Controller
    {










        public IActionResult Index()
        {
            

            return View(ClassHelper.UserRepo.users);
        }




    }
}
