using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp3.Shared
{
    public class CourseDto
    {
        public int? CourseId { get; set; }
        public string? CourseName { get; set; }
        public int? StdId { get; set; }
        public long? Marks { get; set; }

        public virtual stdDto? Std { get; set; }
    }
}
