using AspTask2_FormTask.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspTask2_FormTask.Controllers
{
    public class FormController : Controller
    {

        

        public IActionResult Add()
        {



            return View();
        }


        public IActionResult Add(User User)
        {


            return View();
        }
    }
}
