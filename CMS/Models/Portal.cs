using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class Portal
{
    public int Id { get; set; }

    public string Alias { get; set; }

    public string Name { get; set; }

    public bool Active { get; set; }

    public string Disc { get; set; }

    public virtual ICollection<PortalTab> PortalTabs { get; set; } = new List<PortalTab>();
}
