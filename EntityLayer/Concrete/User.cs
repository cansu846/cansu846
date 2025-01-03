﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Kullanılmayacak.
namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]   
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
        public List<UserMessage> Messages { get; set; }
    }
}
