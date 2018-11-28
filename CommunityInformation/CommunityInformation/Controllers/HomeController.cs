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
        IRepository repository;


        #region Constructors
        public HomeController(IRepository repo)
        {
            // tmp cast
            repository = repo;
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
            return View(repository);
        }



        [HttpPost]
        public ViewResult Messages(DateTime startDate, DateTime endDate, string sender, string recipient)
        {

            // add search data
            if (startDate.Ticks != 0)
            {
                ViewBag.SearchByDateStart = startDate;
            }
            if (endDate.Ticks != 0)
            {
                ViewBag.SearchByDateEnd = endDate;
            }
            if (sender != null)
            {
                ViewBag.Sender = sender;
            }
            if (recipient != null)
            {
                ViewBag.Recipient = recipient;
            }
            // View messages
            return View(repository);
        }



        [HttpGet]
        public ViewResult Messenger(string Subject, string Recipient)
        {
            // create message object to store the message to reply to
            Message replyTo = new Message() { Subject = HttpUtility.HtmlDecode(Subject) };
            // set the person who sent the message that we are replying to
            replyTo.SetSenderFromInt(int.Parse(HttpUtility.HtmlDecode(Recipient)), repository);
            // add logged in user
            ViewBag.loggedIn = repository.LoggedIn;
            // add list of users
            ViewBag.users = repository.Users;
            // View messages
            return View("Messenger", replyTo);
        }



        [HttpPost]
        public ViewResult Messenger(int Recipient, string Subject, string Text)
        {
            if (ModelState.IsValid)
            {
                // create new message
                Message newMessage = new Message() { Sender = repository.LoggedIn, Subject = Subject, Text = Text };
                newMessage.SetRecipientFromInt(Recipient, repository);
                // add new message
                repository.AddMessage(newMessage);
                // view messages
                return View("Messages", repository);
            }
            else
            {
                // add logged in user
                ViewBag.loggedIn = repository.LoggedIn;
                // add list of users
                ViewBag.users = repository.Users;
                // error
                return View();
            }

        }
        #endregion
    }
}
