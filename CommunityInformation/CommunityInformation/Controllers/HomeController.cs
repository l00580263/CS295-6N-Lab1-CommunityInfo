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
        public ViewResult Contact()
        {
            // Contact Page
            return View();
        }        
       


        [HttpPost]
        public ViewResult Contact(VisitorMessage vMessage)
        {
            if (ModelState.IsValid)
            {               
                return View("MessageSent", vMessage);
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
