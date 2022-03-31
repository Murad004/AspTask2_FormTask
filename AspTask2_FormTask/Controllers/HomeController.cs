using AspTask2_FormTask.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspTask2_FormTask.Controllers
{
    public class HomeController : Controller
    {


        public List<User> users = new List<User>
        {
            new User
            {
                Id=1,Name="Murad",Surname="Sadikhov",Age=18,ImagePath="~/Image/user.png"
            },
            new User
            {
                Id=2,Name="Cavid",Surname="Mahsumov",Age=16,ImagePath="~/Image/user.png"
            },
            new User
            {
                Id=3,Name="Elxan",Surname="Atayev",Age=16,ImagePath="~/Image/user.png"
            },
            new User
            {
                Id=4,Name="Kamran",Surname="Aliyev",Age=22,ImagePath="~/Image/user.png"
            },
        };

        public IActionResult Index()
        {
            

            return View(users);
        }




    }
}
