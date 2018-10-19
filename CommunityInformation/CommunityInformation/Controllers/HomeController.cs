using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommunityInformation.Models;
using System.Web;

namespace CommunityInformation.Controllers
{
    public class HomeController : Controller
    {



        #region Constructors
        public HomeController()
        {
            if (!Repository.Fresh)
            {
                return;
            }
            // initialize repository
            User user1 = new User() { Name = "Kolton" };
            User user2 = new User() { Name = "Bobby" };
            User user3 = new User() { Name = "Hank" };
            Repository.Users.AddRange(new User[]{user1, user2, user3});
            Message message1 = new Message() { Subject = "This site sucks", Text = "Not kidding, RIP.", Recipient = user2, Sender = user1 };
            Message message2 = new Message() { Subject = "RE: This site sucks", Text = "bruh, swag yeah", Recipient = user1, Sender = user2 };
            Message message4 = new Message() { Subject = "u r loser", Text = "Git gud, Bobby.", Recipient = user2, Sender = user3 };
            Message message3 = new Message() { Subject = "Wait till Bobby sees this!", Text = "Dang it, Bobby.", Recipient = user1, Sender = user3 };
            Repository.Messages.AddRange(new Message[] { message1, message2, message3, message4 });
            // log in as Bobby
            Repository.LoggedIn = user2;
            Repository.Fresh = false;
        }
        #endregion



        #region Methods
        public ViewResult Index()
        {
            // Home Page
            return View();
        }



        public ViewResult History()
        {
            // History Page
            return View();
        }



        [HttpGet]
        public ViewResult Messages()
        {
            // add logged in user
            ViewBag.loggedIn = Repository.LoggedIn;
            // View messages
            return View(Repository.Messages);
        }



        [HttpGet]
        public ViewResult Messenger(string Subject, string Recipient)
        {
            // create message object to store the message to reply to
            Message replyTo = new Message() { Subject = HttpUtility.HtmlDecode(Subject) };
            // set the person who sent the message that we are replying to
            replyTo.SetSenderFromInt(int.Parse(HttpUtility.HtmlDecode(Recipient)));
            // add logged in user
            ViewBag.loggedIn = Repository.LoggedIn;
            // add list of users
            ViewBag.users = Repository.Users;
            // View messages
            return View("Messenger", replyTo);
        }



        [HttpPost]
        public ViewResult Messenger(int Recipient, string Subject, string Text)
        {
            if (ModelState.IsValid)
            {
                // create new message
                Message newMessage = new Message() { Sender = Repository.LoggedIn, Subject = Subject, Text = Text };
                newMessage.SetRecipientFromInt(Recipient);
                // add new message
                Repository.Messages.Add(newMessage);
                // add logged in user
                ViewBag.loggedIn = Repository.LoggedIn;
                // view messages
                return View("Messages", Repository.Messages);
            }
            else
            {
                // add logged in user
                ViewBag.loggedIn = Repository.LoggedIn;
                // add list of users
                ViewBag.users = Repository.Users;
                // error
                return View();
            }

        }
        #endregion
    }
}
