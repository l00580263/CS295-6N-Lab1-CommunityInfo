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
            // create pass object to store messages and logged in user
            MessagesPasser pass = new MessagesPasser() { Messages = Repository.Messages, LoggedUser = Repository.LoggedIn, Users = Repository.Users};
            // View messages
            return View(pass);
        }



        [HttpPost]
        public ViewResult Messages(string Subject, int Recipient)
        {
            // create pass object to store the (message to reply to)'s subject and sender
            MessagesPasser pass = new MessagesPasser() { Subject = Subject, Recipient = Recipient, Users = Repository.Users };
            // View messages
            return View("Messenger", pass);
        }



        [HttpGet]
        public ViewResult Messenger()
        {
            // create pass object to store messages and logged in user
            MessagesPasser pass = new MessagesPasser() { Messages = Repository.Messages, LoggedUser = Repository.LoggedIn, Users = Repository.Users };
            // Message people
            return View(pass);
        }        
       


        [HttpPost]
        public ViewResult Messenger(int Recipient, string Subject, string Text)
        {
            if (ModelState.IsValid)
            {
                Message newMessage = new Message() { Sender = Repository.LoggedIn, Recipient = Repository.Users[Recipient], Subject = Subject, Text = Text };
                // add message
                Repository.Messages.Add(newMessage);
                // create pass object to store messages and logged in user
                MessagesPasser pass = new MessagesPasser() { Messages = Repository.Messages, LoggedUser = Repository.LoggedIn, Users = Repository.Users };
                return View("Messages", pass);
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
