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
            return View("Index");
        }



        public ViewResult Contact()
        {
            // Contact Page
            return View("Contact");
        }



        public ViewResult History()
        {
            // History Page
            return View("History");
        }
        #endregion
    }
}
