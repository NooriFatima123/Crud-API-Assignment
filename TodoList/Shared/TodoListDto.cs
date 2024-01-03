using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Shared
{
    public class TodoListDto
    {
        public int ItemId { get; set; }

        public string? Title { get; set; }

        public string? Desc { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? ModifyOn { get; set; }
        public int? UserId { get; set; }
    }
}
