using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Web;
using System.Security.Cryptography;

using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {

        private DataDbContext dbContext;

        public HomeController(DataDbContext context)
        {
            this.dbContext = context;
            context.Database.EnsureCreated();
        }
        public IActionResult Index()
        {
            int? userId = HttpContext.Session.GetInt32("userId");
            if (userId == null)
            {
                return Redirect("/Home/Login");
            }

            List<Conversations> ListConversation = new List<Conversations>();
            List<Users> ListUsers = new List<Users>();
            List<EmailDetail> listSender = dbContext.EmailDetails.FromSql(@"select * from EmailDetails where senderId = " + userId + ";").ToList();
            List<EmailDetail> listReceive = dbContext.EmailDetails.FromSql(@"select * from EmailDetails where receiverId = " + userId + ";").ToList();
            foreach (var item in listSender)
            {
                var conversSent = dbContext.Conversations.FirstOrDefault(c => c.id == item.conversationId);
                var userReceive = dbContext.Users.FirstOrDefault(c => c.ID == item.receiverId);
                ListConversation.Add(conversSent);
                ListUsers.Add(userReceive);
            }
            foreach (var item in listReceive)
            {
                var conversReceive = dbContext.Conversations.FirstOrDefault(c => c.id == item.conversationId);
                var userSent = dbContext.Users.FirstOrDefault(c => c.ID == item.senderId);
                ListConversation.Add(conversReceive);
                ListUsers.Add(userSent);
            }
            var me = dbContext.Users.FirstOrDefault(u => u.ID == userId);
            ViewBag.user = me;
            ViewBag.listmailsend = listSender;
            ViewBag.ListReceiver = listReceive;
            return View();
        }
        public IActionResult DeleteInbox(int conversationId)
        {
            var converstion = dbContext.EmailDetails.FirstOrDefault(c => c.conversations.id == conversationId);
            if (converstion != null)
            {
                converstion.checkInbox = 1;
                dbContext.SaveChanges();
            }
            return Redirect("/");
        }
        public IActionResult DeleteReceive(int conversationId)
        {
            var converstion = dbContext.EmailDetails.FirstOrDefault(c => c.conversations.id == conversationId);
            if (converstion != null)
            {
                // converstion.checkReceive = 0; 
                converstion.checkReceiver = 1;
                dbContext.SaveChanges();
            }
            return Redirect("/");
        }
        public IActionResult Login(bool Error)
        {
            int? userId = HttpContext.Session.GetInt32("userId");
            if (userId != null)
            {
                return Redirect("/");
            }
            ViewBag.Error = Error;
            return View();
        }
        public IActionResult DetailEmail()
        {
            return View();
        }
        public IActionResult DoLogin(string name, string password, string remember)
        {
            var user = new Users(name, password);

            user = dbContext.Users.FirstOrDefault(a => a.Username == name);

            MD5 md5Hash = MD5.Create();
            if (user == null)
            {
                return Redirect("/Home/Login/?Error=" + true);
            }

            if (VerifyMd5Hash(md5Hash, password, user.Pass))
            {
                if (remember == "on")
                {
                    // Set("username", user.Username, 5);
                }
                HttpContext.Session.SetInt32("userId", user.ID);
                HttpContext.Session.SetString("Logged", "true");
                return Redirect("/?logged=" + true + "&id=" + user.ID);
            }
            else
            {
                return Redirect("/?Error=" + true);

            }
        }
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            string hashOfInput = GetMd5Hash(md5Hash, input);

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }


        [HttpPost]
        public IActionResult Registered(string uname, string upassword)
        {

            var user = new Users();
            user = dbContext.Users.FirstOrDefault(ac => ac.Username == uname);

            if (user != null)
            {
                return Redirect("/Home/Register/?error=" + true);
            }
            else
            {
                var user1 = new Users();
                MD5 md5 = MD5.Create();
                upassword = GetMd5Hash(md5, upassword);
                user1.Username = uname;
                user1.Pass = upassword;

                dbContext.Users.Add(user1);
                dbContext.SaveChanges();
                HttpContext.Session.SetString("Registered", "true");
                return Redirect("/?Registered=" + true + "&id=" + user1.ID);
            }
        }
        [HttpGet]
        public IActionResult Logout()
        {
            // Remove("username");
            HttpContext.Session.Clear();
            return Redirect("/");
        }
        
         public IActionResult Compose(string Receiver, string Title, string Content, bool send)
        {

            if (Receiver.IndexOf(',') != -1)
            {
                string[] receivers = Receiver.Split(',');
                var mail = new Conversations();
                mail.title = Title;
                mail.content = Content;
                dbContext.Add(mail);
                dbContext.SaveChanges();
                foreach (var item in receivers)
                {
                    if (item == "")
                    {
                        break;
                    }
                    Users user = dbContext.Users.FirstOrDefault(x => x.Username == item);
                    var md = new EmailDetail();
                    md.senderId = HttpContext.Session.GetInt32("userId");
                    md.receiverId = user.ID;
                    md.conversationId = mail.id;
                    dbContext.Add(md);
                    dbContext.SaveChanges();
                }
            }

            // if (Receiver.IndexOf(',') != -1)
            // {
            //     string[] userNames = Receiver.Split(",");
            //     var converstion = new Conversations();
            //     converstion.title = Title;
            //     converstion.content = Content;
            //     converstion.mailDate = DateTime.Now;
            //     dbContext.Conversations.Add(converstion);
            //     dbContext.SaveChanges();
            //     foreach (var item in userNames)
            //     {
            //         Console.WriteLine("item: " + item);
            //     }
            //     foreach (var item in userNames)
            //     {
            //         if (item == "")
            //         {
            //             break;
            //         }

            //         var emailDetail = new EmailDetail();
            //         int? userId = HttpContext.Session.GetInt32("userId");
            //         var sender = new Users();
            //         sender = dbContext.Users.FirstOrDefault(s => s.ID == userId);
            //         var user = new Users();
            //         user = dbContext.Users.FirstOrDefault(acc => acc.Username == item);
            //         if (user == null)
            //         {
            //             send = false;
            //             HttpContext.Session.SetString("Compose", "false");
            //             ViewBag.Send = send;
            //             return Redirect("/?Compose=" + send);
            //         }
            //         else
            //         {
            //             emailDetail.senderId = sender.ID;
            //             emailDetail.receiverId = user.ID;
            //             emailDetail.conversations = converstion;
            //             try
            //             {
            //                 converstion.state = Conversations.messageStatus.success;
            //                 send = true;
            //             }
            //             catch (System.Exception)
            //             {
            //                 converstion.state = Conversations.messageStatus.faild;
            //             }
            //             dbContext.EmailDetails.Add(emailDetail);
            //             dbContext.SaveChanges();
            //             return Redirect("/");


            //         }

            //     }
            // }
            else
            {
                var converstion = new Conversations();
                var emailDetail = new EmailDetail();
                int? userId = HttpContext.Session.GetInt32("userId");
                var sender = new Users();
                sender = dbContext.Users.FirstOrDefault(s => s.ID == userId);
                var user = new Users(Receiver);
                user = dbContext.Users.FirstOrDefault(acc => acc.Username == Receiver);
                if (user == null)
                {
                    send = false;
                    HttpContext.Session.SetString("Compose", "false");
                    ViewBag.Send = send;
                    return Redirect("/?Compose=" + send);
                }
                else
                {
                    emailDetail.senderId = sender.ID;
                    emailDetail.receiverId = user.ID;
                    converstion.title = Title;
                    converstion.content = Content;
                    converstion.mailDate = DateTime.Now;
                    emailDetail.conversations = converstion;
                    try
                    {
                        converstion.state = Conversations.messageStatus.success;
                        send = true;
                    }
                    catch (System.Exception)
                    {
                        converstion.state = Conversations.messageStatus.faild;
                    }
                    dbContext.EmailDetails.Add(emailDetail);
                    dbContext.SaveChanges();



                }
            }

            return Redirect("/");
        }
        public IActionResult GetUsers()
        {
            var users = dbContext.Users.ToList();

            return View(users);
        }

        public IActionResult Register(bool error)
        {
            ViewBag.error = error;
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
        // public string Get(string key)
        // {
        //     return Request.Cookies[key];
        // }

        // public void Set(string key, string value, int? expireTime)
        // {
        //     CookieOptions option = new CookieOptions();
        //     if (expireTime.HasValue)
        //         option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
        //     else
        //         option.Expires = DateTime.Now.AddMilliseconds(10);
        //     Response.Cookies.Append(key, value, option);
        // }
        // public void Remove(string key)
        // {
        //     Response.Cookies.Delete(key);
        // }
    }
}
