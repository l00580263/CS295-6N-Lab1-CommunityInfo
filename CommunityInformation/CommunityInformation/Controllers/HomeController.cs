using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommunityInformation.Models;

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
            // View messages
            return View();
        }



        [HttpPost]
        public ViewResult Messages(string Subject, int Recipient)
        {
            // create message object to store the message to reply to
            Message replyTo = new Message() { Subject = Subject };
            // set the person who sent the message that we are replying to
            replyTo.SetSenderFromInt(Recipient);
            // View messages
            return View("Messenger", replyTo);
        }



        [HttpGet]
        public ViewResult Messenger()
        {
            // Message people
            return View();
        }        
       


        [HttpPost]
        public ViewResult Messenger(int Recipient, string Subject, string Text)
        {
            if (ModelState.IsValid)
            {
                // create new message
                Message newMessage = new Message() { Sender = Repository.LoggedIn, Recipient = Repository.Users[Recipient], Subject = Subject, Text = Text };
                // add new message
                Repository.Messages.Add(newMessage);
                // view messages
                return View("Messages");
            }
            else
            {
                // error
                return View();
            }

        }
        #endregion
    }
}
