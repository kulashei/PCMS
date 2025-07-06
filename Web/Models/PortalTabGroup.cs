using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class PortalTabGroup
{
    public int Id { get; set; }

    public string Name { get; set; }

    public bool Active { get; set; }

    public int Ordar { get; set; }

    public string Disc { get; set; }

    public virtual ICollection<PortalTab> PortalTabs { get; set; } = new List<PortalTab>();
}
