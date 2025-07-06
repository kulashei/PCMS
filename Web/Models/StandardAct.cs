using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class StandardAct
{
    public int Id { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<StandardActivity> StandardActivities { get; set; } = new List<StandardActivity>();
}
