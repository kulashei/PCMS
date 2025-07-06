using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class StandardDayworkEx
{
    public int Id { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public virtual ICollection<StandardDayworkRm> StandardDayworkRms { get; set; } = new List<StandardDayworkRm>();

    public virtual ICollection<StandardDaywork> StandardDayworks { get; set; } = new List<StandardDaywork>();
}
