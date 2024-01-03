using System;
using System.Collections.Generic;

namespace BlazorApp3.Server.Database
{
    public partial class Course
    {
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public int? StdId { get; set; }
        public long? Marks { get; set; }

        public virtual Std? Std { get; set; }
    }
}
