using AspTask2_FormTask.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspTask2_FormTask.Models
{
    public class UserViewModel
    {
        public User User { get; set; }
        public IFormFile File { get; set; }
        public bool HasSaved { get; set; }
    }
}
