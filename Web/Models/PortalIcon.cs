using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class PortalIcon
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Url { get; set; }

    public string Altname { get; set; }

    public string Disc { get; set; }

    public virtual ICollection<PortalTab> PortalTabHoverFkNavigations { get; set; } = new List<PortalTab>();

    public virtual ICollection<PortalTab> PortalTabMenuFkNavigations { get; set; } = new List<PortalTab>();
}
