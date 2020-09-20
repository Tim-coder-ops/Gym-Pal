using System;
using System.Collections.Generic;

namespace GymPal.Models
{
    public partial class Sets
    {
        public int Id { get; set; }
        public int? ExerciseId { get; set; }
        public int? NumberOfReps { get; set; }
        public int? Weight { get; set; }
        public int? WorkoutId { get; set; }

        public virtual Exercises Exercise { get; set; }
        public virtual Workout Workout { get; set; }
    }
}
