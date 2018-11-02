using System;
using Xunit;
using CommunityInformation.Models;
using CommunityInformation.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace CommunityInformation.Tests
{
    public class HomeControllerTests
    {

        FakeRepo repo;
        HomeController controller;



        public HomeControllerTests()
        {
            repo = new FakeRepo();
            controller = new HomeController(repo);
        }



        [Fact]
        public void CanSendMessageRecipient()
        {
            // a
            int r = 2;
            string sub = "Test";
            string text = "This is a test";
            // a
            controller.Messenger(r, sub, text);
            // a
            Assert.Equal(repo.Messages[repo.Messages.Count - 1].GetRecipientAsInt(repo), r);
        }



        [Fact]
        public void CanSendMessageSubject()
        {
            // a
            int r = 2;
            string sub = "Test";
            string text = "This is a test";
            // a
            controller.Messenger(r, sub, text);
            // a
            Assert.Equal(repo.Messages[repo.Messages.Count - 1].Subject, sub);
        }



        [Fact]
        public void CanSendMessageText()
        {
            // a
            int r = 2;
            string sub = "Test";
            string text = "This is a test";
            // a
            controller.Messenger(r, sub, text);
            // a
            Assert.Equal(repo.Messages[repo.Messages.Count - 1].Text, text);
        }



        [Fact]
        public void CanSendLoggedUserInViewBag()
        {
            // a
            int r = 2;
            string sub = "Test";
            string text = "This is a test";
            // a
            ViewResult result = controller.Messenger(r, sub, text);
            // a
            Assert.Equal(result.ViewData["loggedIn"], repo.LoggedIn);
        }
    }
}
