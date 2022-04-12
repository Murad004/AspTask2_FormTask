using AspTask2_FormTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspTask2_FormTask.FakeRepo
{
    public class UserRepo
    {
        public static List<User> users = new List<User>
        {
            new User
            {
                Id=1,Name="Murad",Surname="Sadikhov",Age=18
            }
        };

        public List<User> GetAllUsers()
        {
            return users;
        }

    }
}
