using System;
using System.Collections.Generic;

namespace TodoList.Server.Database;

public partial class TodoList
{
    public int ItemId { get; set; }

    public string? Title { get; set; }

    public string? Desc { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? ModifyOn { get; set; }

    public int? UserId { get; set; }

    public virtual User? User { get; set; }
}
