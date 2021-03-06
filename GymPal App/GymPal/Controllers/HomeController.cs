﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GymPal.Models;
using GymPal.Controllers;

namespace GymPal.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("home")]
        public IActionResult Home()
        {
            return View("Index");
        }


         [HttpGet("login")]
         public IActionResult login()
         {
             return View("login");
         }

         [HttpGet("register")]
         public IActionResult register()
         {
             return View("register");
         }

         

         [HttpGet("logWorkout")]
         public IActionResult LogWorkout()
         {
             return View("LogNewWorkout");
         }

         [HttpGet("aboutUs")]
         public IActionResult AboutUs()
         {
             return View("AboutUs");
         }

        
        



    }
}
