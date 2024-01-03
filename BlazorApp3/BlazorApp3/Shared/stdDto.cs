using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp3.Shared
{
    public class stdDto
    {
        public stdDto()
        {
            Courses = new HashSet<CourseDto>();
        }

        public int StdId { get; set; }
        public string? StdName { get; set; }
        public DateTime? StdDof { get; set; }

        public virtual ICollection<CourseDto> Courses { get; set; }
    }
}
