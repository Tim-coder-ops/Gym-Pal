using System;
using System.Collections.Generic;

namespace GymPal.Models
{
    public partial class Progress
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? BodyWeight { get; set; }
        public int? UserId { get; set; }

        public virtual Users User { get; set; }
    }
}
