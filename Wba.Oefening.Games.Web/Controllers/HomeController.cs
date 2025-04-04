﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wba.Oefening.Games.Core.Entities;
using Wba.Oefening.Games.Core.Repositories;
using Wba.Oefening.Games.Web.Models;

namespace Wba.Oefening.Games.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string RateAGame = "<h2>Rate-a-Game!</h2>";
            RateAGame += "<nav><ul><li><a href='./Games'>Games</a></li><li><a href='./Developers'>Developers</a></li></ul> </nav>";
            return Content(RateAGame, "text/html");
        }

        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
