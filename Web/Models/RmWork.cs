using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class RmWork
{
    public int WorkId { get; set; }

    public int Number { get; set; }

    public string WorkDesc { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<RmWorksItem> RmWorksItems { get; set; } = new List<RmWorksItem>();
}
