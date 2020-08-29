using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GymPal.Models;

namespace GymPal.Controllers
{
     public class LoginController : Controller
     {
         public IActionResult Login()
         {
             return View();
         }

         [HttpGet("newregister")]
          public IActionResult register()
          {
              return View("register");
          }
     }
}