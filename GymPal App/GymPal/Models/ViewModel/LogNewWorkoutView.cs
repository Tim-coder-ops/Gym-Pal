using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymPal.Models;
using System.Web;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GymPal.ViewModel
{
    public class LogNewWorkoutView
    {     
        public List<Exercises> exercises { get; set; }

        public Sets sets { get; set; }
    }
}
