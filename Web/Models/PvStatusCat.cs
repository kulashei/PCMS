using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class PvStatusCat
{
    public int Id { get; set; }

    public string Name { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<PvStatus> PvStatuses { get; set; } = new List<PvStatus>();
}
