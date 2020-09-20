using System;
using System.Collections.Generic;

namespace GymPal.Models
{
    public partial class Users
    {
        public Users()
        {
            Progress = new HashSet<Progress>();
            Workout = new HashSet<Workout>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Progress> Progress { get; set; }
        public virtual ICollection<Workout> Workout { get; set; }
    }
}
