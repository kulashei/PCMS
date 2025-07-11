using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class Coverage
{
    public int CoverageId { get; set; }

    public string Coverage1 { get; set; }

    public virtual ICollection<Programme> Programmes { get; set; } = new List<Programme>();
}
