using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MVC.Models
{
   

    public class Users
    {
        public Users()
        {

        }
        public Users(string username)
        {
            Username = username;
        }

        public Users(string username, string pass)
        {

            Username = username;
            Pass = pass;
        }
        public int ID { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        // public EmailDetail emDetail {get;set;}
        // public ICollection<EmailDetail> emailDetails { get; set; }
    }
}