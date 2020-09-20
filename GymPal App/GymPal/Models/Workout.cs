using System;
using System.Collections.Generic;

namespace GymPal.Models
{
    public partial class Workout
    {
        public Workout()
        {
            Sets = new HashSet<Sets>();
        }

        public int Id { get; set; }
        public int? WorkoutNumber { get; set; }
        public int? UserId { get; set; }
        public DateTime? Date { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<Sets> Sets { get; set; }
    }
}
