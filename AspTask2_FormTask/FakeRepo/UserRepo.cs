using AspTask2_FormTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspTask2_FormTask.FakeRepo
{
    public class UserRepo
    {
        public List<User> users = new List<User>
        {
            new User
            {
                Id=1,Name="Murad",Surname="Sadikhov",Age=18,ImageUrl="~/Image/user.png"
            },
            new User
            {
                Id=2,Name="Cavid",Surname="Mahsumov",Age=16,ImageUrl="~/Image/user.png"
            },
            new User
            {
                Id=3,Name="Elxan",Surname="Atayev",Age=16,ImageUrl="~/Image/user.png"
            },
            new User
            {
                Id=4,Name="Kamran",Surname="Aliyev",Age=22,ImageUrl="~/Image/user.png"
            },
        };
    }
}
