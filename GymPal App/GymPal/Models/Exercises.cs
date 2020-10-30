using System;
using System.Collections.Generic;

namespace GymPal.Models
{
    public partial class Exercises
    {
        public Exercises()
        {
            Sets = new HashSet<Sets>();
        }

        public int Id { get; set; }
        public string BodyPart { get; set; }
        public string Exercise { get; set; }
        public string TypeOfWorkout { get; set; }

        public virtual ICollection<Sets> Sets { get; set; }
    }
}
