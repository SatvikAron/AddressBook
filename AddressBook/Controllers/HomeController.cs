﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
using AddressBook.Interfaces;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        private ITimeProvider timeProvider;
        public HomeController(ITimeProvider _timeProvider)
        {
            timeProvider = _timeProvider;
        }
        public IActionResult Index()
        {
            ViewBag.Time = timeProvider.Now.ToString();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult IncreaseMonth()
        {
           timeProvider.Now= timeProvider.Now.AddMonths(1);
            return View("Index");
        }

        public IActionResult DecreaseMonth()
        {
            timeProvider.Now = timeProvider.Now.AddMonths(-1);
            return View("Index");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
