using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymPal.Models
{
    public class UserHomeViewModel
    {
        public List<Sets> Sets { get; set; }

        public SelectList Exercises { get; set; }
        public string SearchString { get; set; }
    }
}
