using System;
using System.Collections.Generic;

namespace BlazorApp3.Server.Database
{
    public partial class Std
    {
        public Std()
        {
            Courses = new HashSet<Course>();
        }

        public int StdId { get; set; }
        public string? StdName { get; set; }
        public DateTime? StdDof { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
