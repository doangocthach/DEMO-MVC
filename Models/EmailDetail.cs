using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models
{
    public class EmailDetail
    {
        public EmailDetail()
        {

        }
        public int EmailDetailId {get;set;}
        public int conversationId { get; set; }

        // [Required]
        public int checkInbox { get; set; }
        // [Index(IsUnique = true)]
        // [Required]
        public int checkReceiver { get; set; }
        public int receiverId { get; set; }
        public int? senderId { get; set; }

        [ForeignKey("senderId")]
        public virtual Users Sender { get; set; }

        [ForeignKey("receiverId")]
        public virtual Users Receiver { get; set; }
        
        [ForeignKey("conversationId")]
        public virtual Conversations conversations { get; set; }




    }

}