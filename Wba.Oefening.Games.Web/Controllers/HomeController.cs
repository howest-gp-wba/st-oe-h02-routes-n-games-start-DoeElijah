﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
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
            RateAGame += "<nav><ul style='list-style: none'><li><a href='./Games'>Games</a></li><li><a href='./Developers'>Developers</a></li></ul> </nav>";
            return Content(RateAGame, "text/html");
        }

        public IActionResult CustomError()
        {
            return View();
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

        [HttpGet]
        public IActionResult FindByIndex(int id)
        {
            int.Parse("not a number");
            return RedirectToAction("CustomError", "Home");
        }
        public IActionResult StatusCode(int code)
        {
            ViewBag.ErrorCode = code;
            return View();
        }



    }
}
