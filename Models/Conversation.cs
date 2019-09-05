using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MVC.Models
{

    public class Conversations
    {
        public Conversations()
        {

        }

        public enum messageStatus
        {
            faild,
            success
        }

        public int id { get; set; }
        public string content { get; set; }
        public messageStatus state { get; set; }
        public DateTime mailDate { get; set; }
        public string title { get; set; }
        // public EmailDetail emDetail { get; set; }
        public ICollection<EmailDetail> emailDetails { get; set; }
        public int? check{get;set;}
        public int? checkReceive{get;set;}
    }

}
